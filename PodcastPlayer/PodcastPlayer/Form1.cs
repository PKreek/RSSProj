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
            string catName = cbxCategory.SelectedItem.ToString();
            Podcast podcast = podcastController.AddPodcast(txtUrl.Text, catName);

            readPodcast();
            //ListViewItem item = new ListViewItem(podcast.Episodes.Count.ToString());
            //item.SubItems.Add(podcast.PodName);
            //item.SubItems.Add(podcast.Frequency.ToString());
            //item.SubItems.Add(podcast.Category);

            //lstPodcasts.Items.Add(item);
           
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
            Category category = categoryController.AddCategory(txtCategory.Text);
            lstCategory.Items.Add(category.CatName);
            
            
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
            podcastController.SavePodcast();
            
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
            categoryController.SaveCategory();
            cbxCategory.Items.Clear();
            fillCategoryCbx();
        }
        private void txtUrl_MouseClick(object sender, MouseEventArgs e)
        {
            txtUrl.Clear();
        }
    }
}