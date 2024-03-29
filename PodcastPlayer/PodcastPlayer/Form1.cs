 using BusinessLayer.Controllers;
using Models;
using System;
using System.CodeDom;
using System.Diagnostics;
using System.Reflection;
using BusinessLayer;
using System.Reflection.Metadata;
using System.Xml;

namespace PodcastPlayer
{
    public partial class Form1 : Form
    {
        PodcastController podcastController;
        CategoryController categoryController;
        Validering validering = new Validering();

        public Form1()
        {
            
            InitializeComponent();
            podcastController = new PodcastController();
            categoryController = new CategoryController();
            updateLists();
            lblDescription.AutoSize = true;
            lblDescription.MaximumSize = new Size(400, 0);
        }

        private async void btnNewPod_Click(object sender, EventArgs e)
        {

            if(cbxCategory.SelectedIndex != -1)
            {
                try
                {
                    validering.isEmpty(txtUrl.Text);
                    string catName = cbxCategory.SelectedItem.ToString();
                    Podcast podcast = await Task.Run(()=>podcastController.AddPodcast(txtUrl.Text, catName));
                    if (!txtChange.Text.Equals(""))
                    {
                        podcast.Name = txtChange.Text;
                    }
                    podcastController.SavePodcast();
                }
                catch(EmptyException)
                {
                    MessageBox.Show("Du m�ste fylla i en URL");
                }
                catch (UriFormatException)
                {
                    MessageBox.Show("Felaktigt format f�r URL");
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Felaktigt format f�r URL");
                }
                catch (HttpRequestException)
                {
                    MessageBox.Show("Podcasten hittades inte. Kontrollera din URL och internetuppkoppling");
                }
                catch (XmlException)
                {
                    MessageBox.Show("Det d�r �r ingen podcast!");
                }
            }
            else
            {
                MessageBox.Show("Du m�ste v�lja en kategori");
            }
            
            readPodcast();
        }

        private void lstPodcasts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = getSelectedIndexFromListView(lstPodcasts);
            lstEpisode.Items.Clear();

            if (index > -1)
            {
                Podcast podcast = podcastController.FilteredPodcasts[index]; 
                foreach (Episode episode in podcast.Episodes)
                {
                    lstEpisode.Items.Add(episode.EpisodeName);
                }
            }
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        { 
            try
            { 
                string ruta = txtCategory.Text;
                validering.isEmpty(ruta);
                validering.toLong(ruta);
                Category category = categoryController.AddCategory(txtCategory.Text);
                lstCategory.Items.Add(category.CatName);
                categoryController.SaveCategory();
                cbxCategory.Items.Clear();
                fillCategoryCbx();
                txtCategory.Clear();           
            }
            catch(EmptyException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ToLongException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSavePod_Click(object sender, EventArgs e)
        {
            int index = getSelectedIndexFromListView(lstPodcasts);

            if (index > -1)
            {
                Podcast podcast = podcastController.Podcasts[index];
                if (cbxCategory.SelectedItem != null) { podcast.Category = cbxCategory.SelectedItem.ToString(); }
                if (!txtChange.Text.Equals(""))
                {
                    podcast.Name = txtChange.Text;
                }
                readPodcast();
                podcastController.SavePodcast();
                txtUrl.Clear();
                txtChange.Clear();
            }
        }

        private void lstEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexEpisode = getSelectedIndexFromListView(lstEpisode);
            int indexPodcast = getSelectedIndexFromListView(lstPodcasts);

            if (indexEpisode > -1)
            {
                lblDescription.Text = podcastController.FilteredPodcasts[indexPodcast].Episodes[indexEpisode].EpisodeDescription;
            }
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            int indexCat = getSelectedIndexFromListView(lstCategory);
            if (indexCat > -1)
            {
                Category category = categoryController.categories[indexCat];
                if (!txtCategory.Text.Equals(""))
                {
                    for (int i = 0; i < podcastController.Podcasts.Count(); i++)
                    {
                        if (category.CatName == podcastController.Podcasts[i].Category)
                        {
                            podcastController.Podcasts[i].Category = txtCategory.Text;
                        }
                    }
                    category.CatName = txtCategory.Text;
                }
                podcastController.SavePodcast();
                categoryController.SaveCategory();
                txtCategory.Clear();
                updateLists();
            }
        }

        private void txtUrl_MouseClick(object sender, MouseEventArgs e)
        {
            txtUrl.Clear();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int indexCat = getSelectedIndexFromListView(lstCategory);

            if (indexCat > -1)
            {
                Category category = categoryController.categories[indexCat];

                DialogResult dialogResult = MessageBox.Show("�r du s�ker att du vill ta bort kategorin och alla podcasts?", "Bekr�fta", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    podcastController.DeletePodcast(category);
                    categoryController.DeleteCategory(indexCat);
                    updateLists();
                    lstEpisode.Items.Clear();
                }
            }
        }

        private void btnDeletePod_Click(object sender, EventArgs e)
        {
            int indexPod = getSelectedIndexFromListView(lstPodcasts);

            if (indexPod > -1)
            {
                Podcast podcast = podcastController.Podcasts[indexPod];  
               
                for (int i = 0; i < podcastController.Podcasts.Count(); i++)
                {
                    if (podcast==podcastController.Podcasts[i])
                    {
                        podcastController.DeletePodcast(i);
                        lstPodcasts.Items.Clear();
                        lstEpisode.Items.Clear();
                        readPodcast();
                    }
                }
            }
        }

        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexCat = getSelectedIndexFromListView(lstCategory);
            if(indexCat > -1)
            {
                Category category =  categoryController.categories[indexCat];
                var list = podcastController.FilterList(category);
                lstPodcasts.Items.Clear();
                lstEpisode.Items.Clear();
                lblDescription.Text = "Beskrivning";
                foreach (var podcast in list)
                {
                    ListViewItem item = new ListViewItem(podcast.Episodes.Count.ToString());
                    item.SubItems.Add(podcast.Name);
                    item.SubItems.Add(podcast.Category);
                    lstPodcasts.Items.Add(item);
                }
            }
        }

        private void lstCategory_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            podcastController.FilteredPodcasts = podcastController.Podcasts;
            readPodcast();
        }

        public void fillCategoryCbx()
        {
            cbxCategory.Items.Clear();
            cbxCategory.Items.AddRange(categoryController.categories.Select(x => x.CatName).ToArray());
        }

        private int getSelectedIndexFromListView(ListView listView)
        {
            ListView.SelectedIndexCollection indexCollection = listView.SelectedIndices;
            int index = (indexCollection.Count > 0) ? indexCollection[0] : -1;

            return index;
        }

        public void readPodcast()
        {
            podcastController.FilteredPodcasts = podcastController.Podcasts;
            lstPodcasts.Items.Clear();
            lstEpisode.Items.Clear();
            lblDescription.Text = "Beskrivning";

            if (podcastController.FilteredPodcasts.Count > 0)
            {
                foreach (var podcast in podcastController.FilteredPodcasts)
                {
                    ListViewItem item = new ListViewItem(podcast.Episodes.Count.ToString());
                    item.SubItems.Add(podcast.Name);
                    item.SubItems.Add(podcast.Category);
                    lstPodcasts.Items.Add(item);
                }
            }
        }

        private void readCategory()
        {
            List<Category> list = categoryController.categories;
            lstCategory.Items.Clear();
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    lstCategory.Items.Add(item.CatName);
                }
            }
        }

        private void updateLists()
        {
            readCategory();
            readPodcast();
            fillCategoryCbx();
        }

        private void btnDisplayInfo_Click(object sender, EventArgs e)
        {
            int indexPod = getSelectedIndexFromListView(lstPodcasts);

            if (indexPod > -1)
            {
                MessageBox.Show(podcastController.Podcasts[indexPod].DisplayInfo());
            }
        }
    }
}