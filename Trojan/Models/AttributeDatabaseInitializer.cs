using System.Collections.Generic;
using System.Data.Entity;

namespace Trojan.Models
{
    public class AttributeDatabaseInitializer : DropCreateDatabaseIfModelChanges<AttributeContext>
    {
        protected override void Seed(AttributeContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetAttributes().ForEach(p => context.Attributes.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Chip Life Cycle"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Abstraction"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Properties"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Location"
                },
            };

            return categories;
        }
 
        private static List<Attribute> GetAttributes()
        {
            var Attributes = new List<Attribute> {
                new Attribute
                {
                    AttributeID = 1,
                    AttributeName = "Specification",
                    Description = "Insertion",
                    ImagePath="one.png",
                    F_in = 0,
                    F_out = 3,
                    CategoryID = 1,
                    CategoryName = "Chip Life Cycle"
               },
                new Attribute 
                {
                    AttributeID = 2,
                    AttributeName = "Design",
                    Description = "Insertion",
                    ImagePath="two.png",
                    F_in = 1,
                    F_out = 2,
                    CategoryID = 1,
                    CategoryName = "Chip Life Cycle"
               },
                new Attribute
                {
                    AttributeID = 3,
                    AttributeName = "Fabrication",
                    Description = "Insertion",
                    ImagePath="three.png",
                    F_in = 1,
                    F_out = 2,
                    CategoryID = 1,
                    CategoryName = "Chip Life Cycle"
                },
                new Attribute
                {
                    AttributeID = 4,
                    AttributeName = "Practiece Testing",
                    Description = "Insertion",
                    ImagePath="four.png",
                    F_in = 1,
                    F_out = 3,
                    CategoryID = 1,
                    CategoryName = "Chip Life Cycle"
                },
                new Attribute
                {
                    AttributeID = 5,
                    AttributeName = "Assembly",
                    Description = "Insertion",
                    ImagePath="five.png",
                    F_in = 1,
                    F_out = 1,
                    CategoryID = 1,
                    CategoryName = "Chip Life Cycle"
                },
                new Attribute
                {
                    AttributeID = 6,
                    AttributeName = "System",
                    Description = "Abstraction",
                    ImagePath="six.png",
                    F_in = 3,
                    F_out = 7,
                    CategoryID = 2,
                    CategoryName = "Abstraction"
                },
                new Attribute
                {
                    AttributeID = 7,
                    AttributeName = "RTL",
                    Description = "Abstraction",
                    ImagePath="seven.png",
                    F_in = 2,
                    F_out = 11,
                    CategoryID = 2,
                    CategoryName = "Abstraction"
                },
                new Attribute
                {
                    AttributeID = 8,
                    AttributeName = "Environment",
                    Description = "Abstraction",
                    ImagePath="eight.png",
                    F_in = 1,
                    F_out = 15,
                    CategoryID = 2,
                    CategoryName = "Abstraction"
                },
                new Attribute
                {
                    AttributeID = 9,
                    AttributeName = "Logic",
                    Description = "Abstraction",
                    ImagePath="nine.png",
                    F_in = 2,
                    F_out = 9,
                    CategoryID = 2,
                    CategoryName = "Abstraction"
                },
                new Attribute
                {
                    AttributeID = 10,
                    AttributeName = "Transistor",
                    Description = "Abstraction",
                    ImagePath="ten.png",
                    F_in = 1,
                    F_out = 10,
                    CategoryID = 2,
                    CategoryName = "Abstraction"
                },
                new Attribute
                {
                    AttributeID = 11,
                    AttributeName = "Physical",
                    Description = "Abstraction",
                    ImagePath="eleven.png",
                    F_in = 2,
                    F_out = 12,
                    CategoryID = 2,
                    CategoryName = "Abstraction"
                },
                new Attribute
                {
                    AttributeID = 12,
                    AttributeName = "Change In Functionality",
                    Description = "Effect",
                    ImagePath="twelve.png",
                    F_in = 18,
                    F_out = 17,
                    CategoryID = 3,
                    CategoryName = "Properties"
                },
                new Attribute
                {
                    AttributeID = 13,
                    AttributeName = "Information Leakage",
                    Description = "Effect",
                    ImagePath="thirteen.png",
                    F_in = 10,
                    F_out = 13,
                    CategoryID = 3,
                    CategoryName = "Properties"
                },
                new Attribute
                {
                    AttributeID = 14,
                    AttributeName = "Reliability",
                    Description = "Effect",
                    ImagePath="fourteen.png",
                    F_in = 8,
                    F_out = 11,
                    CategoryID = 3,
                    CategoryName = "Properties"
                },
                new Attribute
                {
                    AttributeID = 15,
                    AttributeName = "Denial of Service",
                    Description = "Effect",
                    ImagePath="fifteen.png",
                    F_in = 16,
                    F_out = 16,
                    CategoryID = 3,
                    CategoryName = "Properties"
                },
                new Attribute
                {
                    AttributeID = 16,
                    AttributeName = "Sequential",
                    Description = "Logic Type",
                    ImagePath="sixteen.png",
                    F_in = 13,
                    F_out = 15,
                    CategoryID = 3,
                    CategoryName = "Properties"
                },
                new Attribute
                {
                    AttributeID = 17,
                    AttributeName = "Combinational",
                    Description = "Logic Type",
                    ImagePath="seventeen.png",
                    F_in = 17,
                    F_out = 18,
                    CategoryID = 3,
                    CategoryName = "Properties"
                },
                new Attribute
                {
                    AttributeID = 18,
                    AttributeName = "Functional",
                    Description = "Functionality",
                    ImagePath="eighteen.png",
                    F_in = 19,
                    F_out = 18,
                    CategoryID = 3,
                    CategoryName = "Properties"
                },
                new Attribute
                {
                    AttributeID = 19,
                    AttributeName = "Parametric",
                    Description = "Functionality",
                    ImagePath="nineteen.png",
                    F_in = 9,
                    F_out = 9,
                    CategoryID = 3,
                    CategoryName = "Properties"
                },
                new Attribute
                {
                    AttributeID = 20,
                    AttributeName = "Always On",
                    Description = "Activation",
                    ImagePath="twenty.png",
                    F_in = 19,
                    F_out = 18,
                    CategoryID = 3,
                    CategoryName = "Properties"
                },
                new Attribute
                {
                    AttributeID = 21,
                    AttributeName = "Internally Triggered",
                    Description = "Activation",
                    ImagePath="twenty_one.png",
                    F_in = 13,
                    F_out = 15,
                    CategoryID = 3,
                    CategoryName = "Properties"
                },
                new Attribute
                {
                    AttributeID = 22,
                    AttributeName = "Externally Triggered",
                    Description = "Activation",
                    ImagePath="twenty_two.png",
                    F_in = 12,
                    F_out = 14,
                    CategoryID = 3,
                    CategoryName = "Properties"
                },
                new Attribute
                {
                    AttributeID = 23,
                    AttributeName = "Large",
                    Description = "Physical Layout",
                    ImagePath="twenty_three.png",
                    F_in = 14,
                    F_out = 13,
                    CategoryID = 3,
                    CategoryName = "Properties"
                },
                new Attribute
                {
                    AttributeID = 24,
                    AttributeName = "Small",
                    Description = "Physical Layout",
                    ImagePath="twenty_four.png",
                    F_in = 16,
                    F_out = 17,
                    CategoryID = 3,
                    CategoryName = "Properties"
                },
                new Attribute
                {
                    AttributeID = 25,
                    AttributeName = "Changed Layout",
                    Description = "Physical Layout",
                    ImagePath="twenty_five.png",
                    F_in = 11,
                    F_out = 14,
                    CategoryID = 3,
                    CategoryName = "Properties"
                },
                new Attribute
                {
                    AttributeID = 26,
                    AttributeName = "Augmented",
                    Description = "Physical Layout",
                    ImagePath="twenty_six.png",
                    F_in = 19,
                    F_out = 21,
                    CategoryID = 3,
                    CategoryName = "Properties"
                },
                new Attribute
                {
                    AttributeID = 27,
                    AttributeName = "Clustered",
                    Description = "Physical Layout",
                    ImagePath="twenty_seven.png",
                    F_in = 17,
                    F_out = 19,
                    CategoryID = 3,
                    CategoryName = "Properties"
                },
                new Attribute
                {
                    AttributeID = 28,
                    AttributeName = "Distributed",
                    Description = "Physical Layout",
                    ImagePath="twenty_eight.png",
                    F_in = 14,
                    F_out = 17,
                    CategoryID = 3,
                    CategoryName = "Properties"
                },
                new Attribute
                {
                    AttributeID = 29,
                    AttributeName = "Processor",
                    Description = "Location",
                    ImagePath="twenty_nine.png",
                    F_in = 16,
                    F_out = 0,
                    CategoryID = 4,
                    CategoryName = "Location"
                },
                new Attribute
                {
                    AttributeID = 30,
                    AttributeName = "Memory",
                    Description = "Location",
                    ImagePath="thirty.png",
                    F_in = 15,
                    F_out = 0,
                    CategoryID = 4,
                    CategoryName = "Location"
                },
                new Attribute
                {
                    AttributeID = 31,
                    AttributeName = "I/O",
                    Description = "Location",
                    ImagePath="thirty_one.png",
                    F_in = 16,
                    F_out = 0,
                    CategoryID = 4,
                    CategoryName = "Location"
                },
                new Attribute
                {
                    AttributeID = 32,
                    AttributeName = "Power Supply",
                    Description = "Location",
                    ImagePath="thirty_two.png",
                    F_in = 16,
                    F_out = 0,
                    CategoryID = 4,
                    CategoryName = "Location"
                },
                new Attribute
                {
                    AttributeID = 33,
                    AttributeName = "Clock Grid",
                    Description = "Location",
                    ImagePath="thirty_three.png",
                    F_in = 16,
                    F_out = 0,
                    CategoryID = 4,
                    CategoryName = "Location"
                },
            };

            return Attributes;
        }
    }
}