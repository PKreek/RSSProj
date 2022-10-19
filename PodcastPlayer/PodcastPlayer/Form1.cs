using BusinessLayer.Controllers;
using Models;
using System;

namespace PodcastPlayer
{
    public partial class Form1 : Form
    {
        PodcastController podcastController;
        public Form1()
        {
            InitializeComponent();
            podcastController = new PodcastController();
        }
        //Podcast podcast = podcastController.Podcasts[];
        //foreach (var item in podcast.Episodes)
        //{
        //    lstEpisode.Items.Add(item.EpisodeName);
        //}
        private void btnNewPod_Click(object sender, EventArgs e)
        {
            Podcast podcast = podcastController.AddPodcast(txtUrl.Text);
            ListViewItem item = new ListViewItem(podcastController.EpisodesList(podcast).Count.ToString());
            item.SubItems.Add(podcast.PodName);
            lstPodcasts.Items.Add(item);
        }

        private void lstPodcasts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection index = lstPodcasts.SelectedIndices;
            lstEpisode.Items.Clear();

            if (index.Count > 0)
            {
                Podcast podcast = podcastController.RetrieveAllPods()[index[0]]; //samlingen index innehåller bara ett element som har index 0
                foreach (var item in podcastController.EpisodesList(podcast)) 
                {
                    lstEpisode.Items.Add(item.EpisodeName);
                }
            }
        }
    }
}