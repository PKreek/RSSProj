using BusinessLayer.Controllers;
using Models;

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

        private void btnNewPod_Click(object sender, EventArgs e)
        {
            Podcast podcast = podcastController.AddPodcast(txtUrl.Text);
            lstPodcasts.Items.Add(podcast.Episodes.Count.ToString());
            lstPodcasts.Items.Add(podcast.PodName);
            foreach (var item in podcast.Episodes) 
            {
                lstEpisode.Items.Add(item.EpisodeName);
            }
         
        }
    }
}