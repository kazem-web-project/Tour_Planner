using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeatureProject.Models;

namespace FeatureProject.DummyData
{
    public static class DummyTours
    {
        internal static readonly List<Tour> Tours = new()
        {
            new Tour
            {
                _name = "Vienna City Highlights",
                _description = "Explore the most famous landmarks of Vienna on this walking tour.",
                _from = "Vienna State Opera",
                _to = "Schönbrunn Palace",
                _vehicle = "Walking",
                _distance = 5.0f, // Distance in kilometers (float)
                _duration = new TimeSpan(2, 0, 0), // Duration (2 hours)
            },

            new Tour
            {
                _name = "Danube Canal Bike Tour",
                _description = "Enjoy a scenic bike ride along the Danube Canal and explore Vienna's historic center.",
                _from = "Praterstern",
                _to = "Schwedenplatz",
                _vehicle = "Bicycle",
                _distance = 12.0f,
                _duration = new TimeSpan(3, 0, 0)
            },

            new Tour
            {
                _name = "Vienna Woods Hike",
                _description = "Immerse yourself in nature and explore the beautiful Vienna Woods on this hiking tour.",
                _from = "Heiligenstadt",
                _to = "Kahlenberg",
                _vehicle = "Hiking",
                _distance = 8.0f,
                _duration = new TimeSpan(4, 0, 0)
            },

            new Tour
            {
               _name = "Schönbrunn Palace & Gardens Tour",
                _description = "Discover the grandeur of Schönbrunn Palace and its stunning gardens on this guided tour.",
                _from = "Vienna City Center",
                _to = "Schönbrunn Palace",
                _vehicle = "Public transport",
                _distance = 5.0f,
                _duration = new TimeSpan(2, 30, 0), // Duration (2 hours and 30 minutes)
            },

        };
    
    }

}

