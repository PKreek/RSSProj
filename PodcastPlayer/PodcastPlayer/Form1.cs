using BusinessLayer.Controllers;
using Models;
using System;
using System.Diagnostics;
using System.Reflection;

namespace PodcastPlayer
{
    public partial class Form1 : Form
    {
        PodcastController podcastController;
        CategoryController categoryController;

        public Form1()
        {
            InitializeComponent();
            podcastController = new PodcastController();
            categoryController = new CategoryController();
            readCategory();
            fillCategoryCbx();
            readPodcast();
            lblDescription.AutoSize = true;
            lblDescription.MaximumSize = new Size(400, 0);
        }

        private async void btnNewPod_Click(object sender, EventArgs e)
        {

            if(cbxCategory.SelectedIndex != -1)
            {
                try
                {
                    string catName = cbxCategory.SelectedItem.ToString();
                    Podcast podcast = await Task.Run(()=>podcastController.AddPodcast(txtUrl.Text, catName));
                    if (!txtChange.Text.Equals(""))
                    {
                        podcast.Name = txtChange.Text;
                    }
                    podcastController.SavePodcast();
                }
                catch (UriFormatException)
                {
                    MessageBox.Show("Felaktigt format för URL");
                }
                catch (HttpRequestException)
                {
                    MessageBox.Show("Podcasten hittades inte. Kontrollera din URL");
                }
            }
            else
            {
                MessageBox.Show("Du måste välja en kategori");
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

            if (txtCategory.Text == "h")
            {
                MessageBox.Show("fel");

                throw new EmptyException();
            }
            else
            {
                Category category = categoryController.AddCategory(txtCategory.Text);
                lstCategory.Items.Add(category.CatName);
                categoryController.SaveCategory();
                cbxCategory.Items.Clear();
                fillCategoryCbx();
                txtCategory.Clear();
            }
        }

        private void btnSavePod_Click(object sender, EventArgs e)
        {
            int index = getSelectedIndexFromListView(lstPodcasts);

            if (index > -1)
            {
                Podcast podcast = podcastController.Podcasts[index];
                //podcast.Name = txtChange.Text;
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
                readCategory();
                cbxCategory.Items.Clear();
                fillCategoryCbx();
                podcastController.SavePodcast();
                categoryController.SaveCategory();
                txtCategory.Clear();
                readPodcast();
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

                DialogResult dialogResult = MessageBox.Show("Är du säker att du vill ta bort kategorin och alla podcasts?", "Bekräfta", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < categoryController.categories.Count(); i++)
                    {
                        if (category == categoryController.categories[i])
                        {
                            podcastController.DeletePodcast(category);
                            //List<Podcast> podcastlista = podcastController.Podcasts;

                            //podcastlista.RemoveAll(x => x.Category.Equals(category.CatName));
                            //for (int j = 0; j < podcastController.Podcasts.Count; j++)
                            //{
                            //    if (category.CatName == podcastController.Podcasts[j].Category)
                            //    {
                            //        podcastController.DeletePodcast(j);
                            //    }
                            //}
                            categoryController.DeleteCategory(i);
                            readCategory();
                            cbxCategory.Items.Clear();
                            fillCategoryCbx();
                            readPodcast();
                            lstEpisode.Items.Clear();
                            podcastController.SavePodcast();
                            categoryController.SaveCategory();
                        }
                    }
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
                foreach (var podcast in list)
                {
                    ListViewItem item = new ListViewItem(podcast.Episodes.Count.ToString());
                    item.SubItems.Add(podcast.Name);
                    item.SubItems.Add(podcast.Frequency.ToString());
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
            List<Category> list = categoryController.categories;
            foreach (var item in list)
            {
                cbxCategory.Items.Add(item.CatName);
            }
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

            if (podcastController.FilteredPodcasts.Count > 0)
            {
                foreach (var podcast in podcastController.FilteredPodcasts)
                {
                    ListViewItem item = new ListViewItem(podcast.Episodes.Count.ToString());
                    item.SubItems.Add(podcast.Name);
                    item.SubItems.Add(podcast.Frequency.ToString());
                    item.SubItems.Add(podcast.Category);
                    lstPodcasts.Items.Add(item);
                }
            }
        }

        public void readCategory()
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
    }
}