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
        }
        //Podcast podcast = podcastController.Podcasts[];
        //foreach (var item in podcast.Episodes)
        //{
        //    lstEpisode.Items.Add(item.EpisodeName);
        //}
        private void btnNewPod_Click(object sender, EventArgs e)
        {
            Podcast podcast = podcastController.AddPodcast(txtUrl.Text);
            int podIndex = lstPodcasts.Items.Count;
            ListViewItem item = new ListViewItem(podcastController.NumberOfEpisodes(podIndex).ToString());
            item.SubItems.Add(podcast.PodName);
            lstPodcasts.Items.Add(item);
        }

        private void lstPodcasts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection index = lstPodcasts.SelectedIndices;
            lstEpisode.Items.Clear();

            if (index.Count > 0)
            {
                Podcast podcast = podcastController.Podcasts[index[0]]; //samlingen index innehåller bara ett element som har index 0
                foreach (var item in podcastController.EpisodesList(podcast))
                {
                    lstEpisode.Items.Add(item.EpisodeName);
                }
            }
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            Category category = categoryController.AddCategory(txtCategory.Text);
            lstCategory.Items.Add(category.CatName);
            cbxCategory.Items.Clear();
            fillCategoryCbx();
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
            int podIndex = 0;
            if (list.Count > 0)
            {
                foreach (var podcast in list)
                {
                    ListViewItem item = new ListViewItem(podcastController.NumberOfEpisodes(podIndex).ToString());
                    item.SubItems.Add(podcast.PodName);
                    lstPodcasts.Items.Add(item);
                    podIndex++;
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
            Process.Start(new ProcessStartInfo { FileName = @"https://www.youtube.com/watch?v=5xxQs34UMx4&ab_channel=SMASWL", UseShellExecute = true });
            podcastController.SavePodcast();
        }

        private void lstEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection index = lstEpisode.SelectedIndices;
            ListView.SelectedIndexCollection index2 = lstPodcasts.SelectedIndices;

            if (index.Count > 0)
            {
                    lblEpisode.Text = ("Podcast #" + index2[0] + " Avsnitt " + index[0]);
            }

        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://www.youtube.com/watch?v=dQw4w9WgXcQ&ab_channel=RickAstley", UseShellExecute = true });
        }
        private void txtUrl_MouseClick(object sender, MouseEventArgs e)
        {
            txtUrl.Clear();
        }
    }
}