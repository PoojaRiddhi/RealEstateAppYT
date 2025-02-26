using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiFirstApp.Model
{
    public class PropertyRepo
    {
        public static List<Property> AllProperties => new List<Property>
        {
            new Property
            {
                Address="Manhattan, New York",
                Price=350550,
                DefaultImage="residence-2219972_1280.jpg",
                Images = new List<string>
                {
                    "interior-4226020_640.jpg",
                    "interior-design-6846350_640.jpg",
                    "room-6334131_640.jpg"
                }
            },
            new Property
            {
                Address="Queens, New York",
                Price=550550,
                DefaultImage="residence-2219972_1280.jpg",
                Images = new List<string>
                {
                    "interior-4226020_640.jpg",
                    "interior-design-6846350_640.jpg",
                    "room-6334131_640.jpg"
                }
            },
            new Property
            {
                Address="Manhattan, New York",
                Price=350550,
                DefaultImage="residence-2219972_1280.jpg",
                Images = new List<string>
                {
                    "interior-4226020_640.jpg",
                    "interior-design-6846350_640.jpg",
                    "room-6334131_640.jpg"
                }
            },
            new Property
            {
                Address="Brooklyn, New York",
                Price=350550,
                DefaultImage="residence-2219972_1280.jpg",
                Images = new List<string>
                {
                    "interior-4226020_640.jpg",
                    "interior-design-6846350_640.jpg",
                    "room-6334131_640.jpg",
                    "interior-4226020_640.jpg",
                    "interior-design-6846350_640.jpg",
                    "room-6334131_640.jpg"
                }
            }
        };
    }
}
