﻿using DataAccessLayer;
using Models;
using System;
using System.Net;
using System.ServiceModel.Syndication;
using System.Text.RegularExpressions;
using System.Xml;

namespace DataAccess
{
    public class FeedReader : IFeedReader
    {
        public Podcast ReadFeed (string url)
        {
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);

            Podcast podcast = new Podcast(feed.Title.Text, url);

            foreach (SyndicationItem item in feed.Items)
            {
                string description = item.Summary.Text;
                description = Regex.Replace(description, @"<.+?>", String.Empty);
                Episode episode = new Episode(item.Title.Text, description);
                podcast.Episodes.Add(episode);
            }

            return podcast;
        }

    }
}