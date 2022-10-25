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
            lasCategory();
            fillCategoryCbx();
            readPodcast();
            lblDescription.AutoSize = true;
            lblDescription.MaximumSize = new Size(400, 0);
        }
        //Podcast podcast = podcastController.Podcasts[];
        //foreach (var item in podcast.Episodes)
        //{
        //    lstEpisode.Items.Add(item.EpisodeName);
        //}
        private void btnNewPod_Click(object sender, EventArgs e)
        {

            if(cbxCategory.SelectedIndex != -1)
            {
                try
                {
                    string catName = cbxCategory.SelectedItem.ToString();
                    Podcast podcast = podcastController.AddPodcast(txtUrl.Text, catName);
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
            ListView.SelectedIndexCollection index = lstPodcasts.SelectedIndices;
            lstEpisode.Items.Clear();

            if (index.Count > 0)
            {
                Podcast podcast = podcastController.Podcasts[index[0]]; //samlingen index innehåller bara ett element som har index 0
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
            }
        }
        public void lasCategory()
        {
            List<Category> list = categoryController.readCategory();
            foreach (var item in list)
            {
                lstCategory.Items.Add(item.CatName);
            }

        }

        public void readPodcast()
        {
            List<Podcast> list = podcastController.Podcasts;
            lstPodcasts.Items.Clear();

            if (list.Count > 0)
            {
                foreach (var podcast in list)
                {
                    ListViewItem item = new ListViewItem(podcast.Episodes.Count.ToString());
                    item.SubItems.Add(podcast.PodName);
                    item.SubItems.Add(podcast.Frequency.ToString());
                    item.SubItems.Add(podcast.Category);
                    lstPodcasts.Items.Add(item);
                }
            }

        }
        public void fillCategoryCbx()
        {
            List<Category> list = categoryController.readCategory();
            foreach (var item in list)
            {
                cbxCategory.Items.Add(item.CatName);
            }
        }

        private void btnSavePod_Click(object sender, EventArgs e)
        {
            
        }

        private void lstEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indexEpisode = lstEpisode.SelectedIndices;
            ListView.SelectedIndexCollection indexPodcast = lstPodcasts.SelectedIndices;

            if (indexEpisode.Count > 0)
            {
                lblDescription.Text = podcastController.Podcasts[indexPodcast[0]].Episodes[indexEpisode[0]].EpisodeDescription;
            }


            //if (index.Count > 0)
            //{
            //        lblEpisode.Text = ("Podcast #" + index2[0] + " Avsnitt " + index[0]);
            //}

        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            
        }
        private void txtUrl_MouseClick(object sender, MouseEventArgs e)
        {
            txtUrl.Clear();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indexCat = lstCategory.SelectedIndices;

            if (indexCat.Count > 0)
            {
                Category category = categoryController.categories[indexCat[0]];

                for (int i = 0; i < categoryController.categories.Count(); i++)
                {
                    if (category==categoryController.categories[i])
                    {
                        podcastController.DeletePodcastByCategory(category);
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
                        lstCategory.Clear();
                        lasCategory();
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

        private void btnDeletePod_Click(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indexPod = lstPodcasts.SelectedIndices;

            if (indexPod.Count > 0)
            {
                Podcast podcast = podcastController.Podcasts[indexPod[0]];  
               
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
    }
}