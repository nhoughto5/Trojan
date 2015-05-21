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
                    CategoryID = 1
               },
                new Attribute 
                {
                    AttributeID = 2,
                    AttributeName = "Design",
                    Description = "Insertion",
                    CategoryID = 1
               },
                new Attribute
                {
                    AttributeID = 3,
                    AttributeName = "Fabrication",
                    Description = "Insertion",
                    CategoryID = 1
                },
                new Attribute
                {
                    AttributeID = 4,
                    AttributeName = "Testing",
                    Description = "Insertion",
                    CategoryID = 1
                },
                new Attribute
                {
                    AttributeID = 5,
                    AttributeName = "Assembly",
                    Description = "Insertion",
                    CategoryID = 1
                },
                new Attribute
                {
                    AttributeID = 6,
                    AttributeName = "System",
                    Description = "Abstraction",
                    CategoryID = 2
                },
                new Attribute
                {
                    AttributeID = 7,
                    AttributeName = "RTL",
                    Description = "Abstraction",
                    CategoryID = 2
                },
                new Attribute
                {
                    AttributeID = 8,
                    AttributeName = "Environment",
                    Description = "Abstraction",
                    CategoryID = 2
                },
                new Attribute
                {
                    AttributeID = 9,
                    AttributeName = "Logic",
                    Description = "Abstraction",
                    CategoryID = 2
                },
                new Attribute
                {
                    AttributeID = 10,
                    AttributeName = "Transistor",
                    Description = "Abstraction",
                    CategoryID = 3
                },
                new Attribute
                {
                    AttributeID = 11,
                    AttributeName = "Physical",
                    Description = "Abstraction",
                    CategoryID = 2
                },
                new Attribute
                {
                    AttributeID = 12,
                    AttributeName = "Change In Functionality",
                    Description = "Effect",
                    CategoryID = 3
                },
                new Attribute
                {
                    AttributeID = 13,
                    AttributeName = "Information Leakage",
                    Description = "Effect",
                    CategoryID = 3
                },
                new Attribute
                {
                    AttributeID = 14,
                    AttributeName = "Reliability",
                    Description = "Effect",
                    CategoryID = 3
                },
                new Attribute
                {
                    AttributeID = 15,
                    AttributeName = "Denial of Service",
                    Description = "Effect",
                    CategoryID = 3
                },
                new Attribute
                {
                    AttributeID = 16,
                    AttributeName = "Sequential",
                    Description = "Logic Type",
                    CategoryID = 3
                },
                new Attribute
                {
                    AttributeID = 17,
                    AttributeName = "Combinational",
                    Description = "Logic Type",
                    CategoryID = 3
                },
                new Attribute
                {
                    AttributeID = 18,
                    AttributeName = "Functional",
                    Description = "Functionality",
                    CategoryID = 3
                },
                new Attribute
                {
                    AttributeID = 19,
                    AttributeName = "Parametric",
                    Description = "Functionality",
                    CategoryID = 3
                },
                new Attribute
                {
                    AttributeID = 20,
                    AttributeName = "Always On",
                    Description = "Activation",
                    CategoryID = 3
                },
                new Attribute
                {
                    AttributeID = 21,
                    AttributeName = "Internally Triggered",
                    Description = "Activation",
                    CategoryID = 3
                },
                new Attribute
                {
                    AttributeID = 22,
                    AttributeName = "Externally Triggered",
                    Description = "Activation",
                    CategoryID = 3
                },
                new Attribute
                {
                    AttributeID = 23,
                    AttributeName = "Large",
                    Description = "Physical Layout",
                    CategoryID = 3
                },
                new Attribute
                {
                    AttributeID = 24,
                    AttributeName = "Small",
                    Description = "Physical Layout",
                    CategoryID = 3
                },
                new Attribute
                {
                    AttributeID = 25,
                    AttributeName = "Changed Layout",
                    Description = "Physical Layout",
                    CategoryID = 3
                },
                new Attribute
                {
                    AttributeID = 26,
                    AttributeName = "Augmented",
                    Description = "Physical Layout",
                    CategoryID = 3
                },
                new Attribute
                {
                    AttributeID = 27,
                    AttributeName = "Clustered",
                    Description = "Physical Layout",
                    CategoryID = 3
                },
                new Attribute
                {
                    AttributeID = 28,
                    AttributeName = "Distributed",
                    Description = "Physical Layout",
                    CategoryID = 3
                },
                new Attribute
                {
                    AttributeID = 29,
                    AttributeName = "Processor",
                    Description = "Location",
                    CategoryID = 4
                },
                new Attribute
                {
                    AttributeID = 30,
                    AttributeName = "Memory",
                    Description = "Location",
                    CategoryID = 4
                },
                new Attribute
                {
                    AttributeID = 31,
                    AttributeName = "I/O",
                    Description = "Location",
                    CategoryID = 4
                },
                new Attribute
                {
                    AttributeID = 32,
                    AttributeName = "Power Supply",
                    Description = "Location",
                    CategoryID = 4
                },
                new Attribute
                {
                    AttributeID = 33,
                    AttributeName = "Clock Grid",
                    Description = "Location",
                    CategoryID = 4
                },
            };

            return Attributes;
        }
    }
}