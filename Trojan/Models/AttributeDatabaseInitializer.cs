using System.Collections.Generic;
using System.Data.Entity;

namespace Trojan.Models
{
    public class AttributeDatabaseInitializer : DropCreateDatabaseAlways<AttributeContext>
    {
        protected override void Seed(AttributeContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetAttributes().ForEach(p => context.Attributes.Add(p));
            GetMatrixRow().ForEach(j => context.MatrixRow.Add(j));
            GetMatrix().ForEach(a => context.default_Matrix.Add(a));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Chip Life Cycle",
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Abstraction",
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Properties",
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Location",
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
                    CategoryName = "Chip Life Cycle",
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
                    CategoryName = "Chip Life Cycle",
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
                    CategoryName = "Chip Life Cycle",
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
                    CategoryName = "Chip Life Cycle",
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
                    CategoryName = "Chip Life Cycle",
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
                    CategoryName = "Abstraction",
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
                    CategoryName = "Abstraction",
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
                    CategoryName = "Abstraction",
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
                    CategoryName = "Abstraction",
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
                    CategoryName = "Abstraction",
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
                    CategoryName = "Abstraction",
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
                    CategoryName = "Properties",
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
                    CategoryName = "Properties",
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
                    CategoryName = "Properties",
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
                    CategoryName = "Properties",
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
                    CategoryName = "Properties",
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
                    CategoryName = "Properties",
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
                    CategoryName = "Properties",
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
                    CategoryName = "Properties",
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
                    CategoryName = "Properties",
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
                    CategoryName = "Properties",
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
                    CategoryName = "Properties",
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
                    CategoryName = "Properties",
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
                    CategoryName = "Properties",
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
                    CategoryName = "Properties",
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
                    CategoryName = "Properties",
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
                    CategoryName = "Properties",
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
                    CategoryName = "Properties",
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
                    CategoryName = "Location",
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
                    CategoryName = "Location",
                },
                new Attribute
                {
                    AttributeID = 31,
                    AttributeName = "IO",
                    Description = "Location",
                    ImagePath="thirty_one.png",
                    F_in = 16,
                    F_out = 0,
                    CategoryID = 4,
                    CategoryName = "Location",
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
                    CategoryName = "Location",
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
                    CategoryName = "Location",
                },
            };

            return Attributes;
        }



        private static List<MatrixRow> GetMatrixRow()
        {
            var Rows = new List<MatrixRow> {
                new MatrixRow
                {
                    AttributeID = 1,
                    A2 = true,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = true,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = false,
                    A13 = false,
                    A14 = false,
                    A15 = false,
                    A16 = false,
                    A17 = false,
                    A18 = false,
                    A19 = false,
                    A20 = false,
                    A21 = false,
                    A22 = false,
                    A23 = false,
                    A24 = false,
                    A25 = false,
                    A26 = false,
                    A27 = false,
                    A28 = false,
                    A29 = false,
                    A30 = false,
                    A31 = false,
                    A32 = false,
                    A33 = false,
               },
               new MatrixRow
                {
                    AttributeID = 2,
                    A1 = false,
                    A2 = false,
                    A3 = true,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = true,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = false,
                    A13 = false,
                    A14 = false,
                    A15 = false,
                    A16 = false,
                    A17 = false,
                    A18 = false,
                    A19 = false,
                    A20 = false,
                    A21 = false,
                    A22 = false,
                    A23 = false,
                    A24 = false,
                    A25 = false,
                    A26 = false,
                    A27 = false,
                    A28 = false,
                    A29 = false,
                    A30 = false,
                    A31 = false,
                    A32 = false,
                    A33 = false,
               },
               new MatrixRow
                {
                    AttributeID = 3,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = true,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = true,
                    A12 = false,
                    A13 = false,
                    A14 = false,
                    A15 = false,
                    A16 = false,
                    A17 = false,
                    A18 = false,
                    A19 = false,
                    A20 = false,
                    A21 = false,
                    A22 = false,
                    A23 = false,
                    A24 = false,
                    A25 = false,
                    A26 = false,
                    A27 = false,
                    A28 = false,
                    A29 = false,
                    A30 = false,
                    A31 = false,
                    A32 = false,
                    A33 = false,
               },
               new MatrixRow
                {
                    AttributeID = 4,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = true,
                    A6 = true,
                    A7 = false,
                    A8 = false,
                    A9 = true,
                    A10 = false,
                    A11 = false,
                    A12 = false,
                    A13 = false,
                    A14 = false,
                    A15 = false,
                    A16 = false,
                    A17 = false,
                    A18 = false,
                    A19 = false,
                    A20 = false,
                    A21 = false,
                    A22 = false,
                    A23 = false,
                    A24 = false,
                    A25 = false,
                    A26 = false,
                    A27 = false,
                    A28 = false,
                    A29 = false,
                    A30 = false,
                    A31 = false,
                    A32 = false,
                    A33 = false,
               },
               new MatrixRow
                {
                    AttributeID = 5,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = true,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = false,
                    A13 = false,
                    A14 = false,
                    A15 = false,
                    A16 = false,
                    A17 = false,
                    A18 = false,
                    A19 = false,
                    A20 = false,
                    A21 = false,
                    A22 = false,
                    A23 = false,
                    A24 = false,
                    A25 = false,
                    A26 = false,
                    A27 = false,
                    A28 = false,
                    A29 = false,
                    A30 = false,
                    A31 = false,
                    A32 = false,
                    A33 = false,
               },
               new MatrixRow
                {
                    AttributeID = 6,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = true,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = true,
                    A13 = true,
                    A14 = false,
                    A15 = true,
                    A16 = false,
                    A17 = false,
                    A18 = true,
                    A19 = true,
                    A20 = true,
                    A21 = false,
                    A22 = false,
                    A23 = false,
                    A24 = false,
                    A25 = false,
                    A26 = false,
                    A27 = false,
                    A28 = false,
                    A29 = false,
                    A30 = false,
                    A31 = false,
                    A32 = false,
                    A33 = false,
               },
               new MatrixRow
                {
                    AttributeID = 7,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = true,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = true,
                    A13 = false,
                    A14 = false,
                    A15 = true,
                    A16 = true,
                    A17 = true,
                    A18 = true,
                    A19 = false,
                    A20 = true,
                    A21 = true,
                    A22 = true,
                    A23 = true,
                    A24 = true,
                    A25 = false,
                    A26 = false,
                    A27 = false,
                    A28 = false,
                    A29 = false,
                    A30 = false,
                    A31 = false,
                    A32 = false,
                    A33 = false,
               },
               new MatrixRow
                {
                    AttributeID = 8,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = true,
                    A10 = false,
                    A11 = false,
                    A12 = true,
                    A13 = false,
                    A14 = false,
                    A15 = true,
                    A16 = true,
                    A17 = true,
                    A18 = true,
                    A19 = false,
                    A20 = true,
                    A21 = true,
                    A22 = true,
                    A23 = true,
                    A24 = true,
                    A25 = true,
                    A26 = true,
                    A27 = true,
                    A28 = true,
                    A29 = false,
                    A30 = false,
                    A31 = false,
                    A32 = false,
                    A33 = false,
               },
               new MatrixRow
                {
                    AttributeID = 9,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = true,
                    A11 = false,
                    A12 = true,
                    A13 = false,
                    A14 = false,
                    A15 = true,
                    A16 = true,
                    A17 = true,
                    A18 = true,
                    A19 = false,
                    A20 = true,
                    A21 = true,
                    A22 = true,
                    A23 = false,
                    A24 = false,
                    A25 = false,
                    A26 = false,
                    A27 = false,
                    A28 = false,
                    A29 = false,
                    A30 = false,
                    A31 = false,
                    A32 = false,
                    A33 = false,
               },
               new MatrixRow
                {
                    AttributeID = 10,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = true,
                    A12 = true,
                    A13 = false,
                    A14 = true,
                    A15 = false,
                    A16 = false,
                    A17 = true,
                    A18 = true,
                    A19 = true,
                    A20 = true,
                    A21 = false,
                    A22 = false,
                    A23 = false,
                    A24 = true,
                    A25 = false,
                    A26 = true,
                    A27 = true,
                    A28 = false,
                    A29 = false,
                    A30 = false,
                    A31 = false,
                    A32 = false,
                    A33 = false,
               },
               new MatrixRow
                {
                    AttributeID = 11,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = true,
                    A13 = true,
                    A14 = true,
                    A15 = false,
                    A16 = false,
                    A17 = false,
                    A18 = true,
                    A19 = true,
                    A20 = true,
                    A21 = false,
                    A22 = false,
                    A23 = true,
                    A24 = true,
                    A25 = true,
                    A26 = true,
                    A27 = true,
                    A28 = true,
                    A29 = false,
                    A30 = false,
                    A31 = false,
                    A32 = false,
                    A33 = false,
               },
               new MatrixRow
                {
                    AttributeID = 12,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = false,
                    A13 = false,
                    A14 = false,
                    A15 = false,
                    A16 = true,
                    A17 = true,
                    A18 = true,
                    A19 = false,
                    A20 = true,
                    A21 = true,
                    A22 = true,
                    A23 = true,
                    A24 = true,
                    A25 = true,
                    A26 = true,
                    A27 = true,
                    A28 = true,
                    A29 = true,
                    A30 = true,
                    A31 = true,
                    A32 = true,
                    A33 = true,
               },
               new MatrixRow
                {
                    AttributeID = 13,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = false,
                    A13 = false,
                    A14 = false,
                    A15 = false,
                    A16 = false,
                    A17 = true,
                    A18 = false,
                    A19 = true,
                    A20 = true,
                    A21 = false,
                    A22 = true,
                    A23 = false,
                    A24 = true,
                    A25 = false,
                    A26 = true,
                    A27 = true,
                    A28 = true,
                    A29 = true,
                    A30 = true,
                    A31 = true,
                    A32 = true,
                    A33 = true,
               },
               new MatrixRow
                {
                    AttributeID = 14,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = false,
                    A13 = false,
                    A14 = false,
                    A15 = false,
                    A16 = false,
                    A17 = false,
                    A18 = false,
                    A19 = true,
                    A20 = true,
                    A21 = false,
                    A22 = false,
                    A23 = false,
                    A24 = true,
                    A25 = false,
                    A26 = true,
                    A27 = true,
                    A28 = true,
                    A29 = true,
                    A30 = true,
                    A31 = true,
                    A32 = true,
                    A33 = true,
               },
               new MatrixRow
                {
                    AttributeID = 15,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = false,
                    A13 = false,
                    A14 = false,
                    A15 = false,
                    A16 = true,
                    A17 = true,
                    A18 = true,
                    A19 = false,
                    A20 = true,
                    A21 = true,
                    A22 = true,
                    A23 = true,
                    A24 = true,
                    A25 = true,
                    A26 = true,
                    A27 = true,
                    A28 = true,
                    A29 = true,
                    A30 = false,
                    A31 = true,
                    A32 = true,
                    A33 = true,
               },
               new MatrixRow
                {
                    AttributeID = 16,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = true,
                    A13 = false,
                    A14 = false,
                    A15 = true,
                    A16 = false,
                    A17 = false,
                    A18 = true,
                    A19 = false,
                    A20 = false,
                    A21 = true,
                    A22 = true,
                    A23 = true,
                    A24 = false,
                    A25 = true,
                    A26 = true,
                    A27 = true,
                    A28 = true,
                    A29 = true,
                    A30 = true,
                    A31 = true,
                    A32 = true,
                    A33 = true,
               },
               new MatrixRow
                {
                    AttributeID = 17,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = true,
                    A13 = true,
                    A14 = false,
                    A15 = true,
                    A16 = false,
                    A17 = false,
                    A18 = true,
                    A19 = false,
                    A20 = true,
                    A21 = true,
                    A22 = true,
                    A23 = true,
                    A24 = true,
                    A25 = true,
                    A26 = true,
                    A27 = true,
                    A28 = true,
                    A29 = true,
                    A30 = true,
                    A31 = true,
                    A32 = true,
                    A33 = true,
               },
               new MatrixRow
                {
                    AttributeID = 18,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = true,
                    A13 = false,
                    A14 = false,
                    A15 = true,
                    A16 = true,
                    A17 = true,
                    A18 = false,
                    A19 = false,
                    A20 = true,
                    A21 = true,
                    A22 = true,
                    A23 = true,
                    A24 = true,
                    A25 = true,
                    A26 = true,
                    A27 = true,
                    A28 = true,
                    A29 = true,
                    A30 = true,
                    A31 = true,
                    A32 = true,
                    A33 = true,
               },
               new MatrixRow
                {
                    AttributeID = 19,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = false,
                    A13 = true,
                    A14 = true,
                    A15 = false,
                    A16 = false,
                    A17 = false,
                    A18 = false,
                    A19 = false,
                    A20 = true,
                    A21 = false,
                    A22 = false,
                    A23 = false,
                    A24 = true,
                    A25 = false,
                    A26 = true,
                    A27 = false,
                    A28 = true,
                    A29 = false,
                    A30 = false,
                    A31 = true,
                    A32 = true,
                    A33 = true,
               },
               new MatrixRow
                {
                    AttributeID = 20,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = true,
                    A13 = true,
                    A14 = true,
                    A15 = true,
                    A16 = false,
                    A17 = true,
                    A18 = true,
                    A19 = true,
                    A20 = false,
                    A21 = false,
                    A22 = false,
                    A23 = true,
                    A24 = true,
                    A25 = true,
                    A26 = true,
                    A27 = true,
                    A28 = true,
                    A29 = true,
                    A30 = true,
                    A31 = true,
                    A32 = true,
                    A33 = true,
               },
               new MatrixRow
                {
                    AttributeID = 21,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = true,
                    A13 = false,
                    A14 = false,
                    A15 = true,
                    A16 = true,
                    A17 = true,
                    A18 = true,
                    A19 = false,
                    A20 = false,
                    A21 = false,
                    A22 = false,
                    A23 = true,
                    A24 = true,
                    A25 = false,
                    A26 = true,
                    A27 = true,
                    A28 = true,
                    A29 = true,
                    A30 = true,
                    A31 = true,
                    A32 = true,
                    A33 = true,
               },
               new MatrixRow
                {
                    AttributeID = 22,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = true,
                    A13 = true,
                    A14 = false,
                    A15 = true,
                    A16 = true,
                    A17 = true,
                    A18 = true,
                    A19 = false,
                    A20 = false,
                    A21 = false,
                    A22 = false,
                    A23 = false,
                    A24 = true,
                    A25 = false,
                    A26 = true,
                    A27 = true,
                    A28 = false,
                    A29 = true,
                    A30 = true,
                    A31 = true,
                    A32 = true,
                    A33 = true,
               },
               new MatrixRow
                {
                    AttributeID = 23,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = true,
                    A13 = false,
                    A14 = false,
                    A15 = true,
                    A16 = true,
                    A17 = true,
                    A18 = true,
                    A19 = false,
                    A20 = true,
                    A21 = true,
                    A22 = false,
                    A23 = false,
                    A24 = false,
                    A25 = true,
                    A26 = true,
                    A27 = true,
                    A28 = true,
                    A29 = true,
                    A30 = true,
                    A31 = false,
                    A32 = false,
                    A33 = false,
               },
               new MatrixRow
                {
                    AttributeID = 24,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = true,
                    A13 = true,
                    A14 = true,
                    A15 = true,
                    A16 = false,
                    A17 = true,
                    A18 = true,
                    A19 = true,
                    A20 = true,
                    A21 = true,
                    A22 = true,
                    A23 = false,
                    A24 = false,
                    A25 = false,
                    A26 = true,
                    A27 = true,
                    A28 = false,
                    A29 = true,
                    A30 = true,
                    A31 = true,
                    A32 = true,
                    A33 = true,
               },
               new MatrixRow
                {
                    AttributeID = 1,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = true,
                    A13 = false,
                    A14 = false,
                    A15 = true,
                    A16 = true,
                    A17 = true,
                    A18 = true,
                    A19 = false,
                    A20 = true,
                    A21 = false,
                    A22 = false,
                    A23 = true,
                    A24 = false,
                    A25 = false,
                    A26 = true,
                    A27 = true,
                    A28 = false,
                    A29 = true,
                    A30 = true,
                    A31 = true,
                    A32 = true,
                    A33 = true,
               },
               new MatrixRow
                {
                    AttributeID = 26,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = true,
                    A13 = true,
                    A14 = true,
                    A15 = true,
                    A16 = true,
                    A17 = true,
                    A18 = true,
                    A19 = true,
                    A20 = true,
                    A21 = true,
                    A22 = true,
                    A23 = true,
                    A24 = true,
                    A25 = true,
                    A26 = false,
                    A27 = true,
                    A28 = true,
                    A29 = true,
                    A30 = true,
                    A31 = true,
                    A32 = true,
                    A33 = true,
               },
               new MatrixRow
                {
                    AttributeID = 27,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = true,
                    A13 = true,
                    A14 = true,
                    A15 = true,
                    A16 = true,
                    A17 = true,
                    A18 = true,
                    A19 = false,
                    A20 = true,
                    A21 = true,
                    A22 = true,
                    A23 = true,
                    A24 = true,
                    A25 = true,
                    A26 = true,
                    A27 = false,
                    A28 = false,
                    A29 = true,
                    A30 = true,
                    A31 = true,
                    A32 = true,
                    A33 = true,
               },
               new MatrixRow
                {
                    AttributeID = 1,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = true,
                    A13 = true,
                    A14 = true,
                    A15 = true,
                    A16 = true,
                    A17 = true,
                    A18 = true,
                    A19 = true,
                    A20 = true,
                    A21 = true,
                    A22 = false,
                    A23 = true,
                    A24 = false,
                    A25 = false,
                    A26 = true,
                    A27 = false,
                    A28 = false,
                    A29 = true,
                    A30 = true,
                    A31 = true,
                    A32 = true,
                    A33 = true,
               },
               new MatrixRow
                {
                    AttributeID = 29,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = false,
                    A13 = false,
                    A14 = false,
                    A15 = false,
                    A16 = false,
                    A17 = false,
                    A18 = false,
                    A19 = false,
                    A20 = false,
                    A21 = false,
                    A22 = false,
                    A23 = false,
                    A24 = false,
                    A25 = false,
                    A26 = false,
                    A27 = false,
                    A28 = false,
                    A29 = false,
                    A30 = false,
                    A31 = false,
                    A32 = false,
                    A33 = false,
               },
               new MatrixRow
                {
                    AttributeID = 30,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = false,
                    A13 = false,
                    A14 = false,
                    A15 = false,
                    A16 = false,
                    A17 = false,
                    A18 = false,
                    A19 = false,
                    A20 = false,
                    A21 = false,
                    A22 = false,
                    A23 = false,
                    A24 = false,
                    A25 = false,
                    A26 = false,
                    A27 = false,
                    A28 = false,
                    A29 = false,
                    A30 = false,
                    A31 = false,
                    A32 = false,
                    A33 = false,
               },
               new MatrixRow
                {
                    AttributeID = 31,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = false,
                    A13 = false,
                    A14 = false,
                    A15 = false,
                    A16 = false,
                    A17 = false,
                    A18 = false,
                    A19 = false,
                    A20 = false,
                    A21 = false,
                    A22 = false,
                    A23 = false,
                    A24 = false,
                    A25 = false,
                    A26 = false,
                    A27 = false,
                    A28 = false,
                    A29 = false,
                    A30 = false,
                    A31 = false,
                    A32 = false,
                    A33 = false,
               },
               new MatrixRow
                {
                    AttributeID = 32,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = false,
                    A13 = false,
                    A14 = false,
                    A15 = false,
                    A16 = false,
                    A17 = false,
                    A18 = false,
                    A19 = false,
                    A20 = false,
                    A21 = false,
                    A22 = false,
                    A23 = false,
                    A24 = false,
                    A25 = false,
                    A26 = false,
                    A27 = false,
                    A28 = false,
                    A29 = false,
                    A30 = false,
                    A31 = false,
                    A32 = false,
                    A33 = false,
               },
               new MatrixRow
                {
                    AttributeID = 33,
                    A1 = false,
                    A2 = false,
                    A3 = false,
                    A4 = false,
                    A5 = false,
                    A6 = false,
                    A7 = false,
                    A8 = false,
                    A9 = false,
                    A10 = false,
                    A11 = false,
                    A12 = false,
                    A13 = false,
                    A14 = false,
                    A15 = false,
                    A16 = false,
                    A17 = false,
                    A18 = false,
                    A19 = false,
                    A20 = false,
                    A21 = false,
                    A22 = false,
                    A23 = false,
                    A24 = false,
                    A25 = false,
                    A26 = false,
                    A27 = false,
                    A28 = false,
                    A29 = false,
                    A30 = false,
                    A31 = false,
                    A32 = false,
                    A33 = false,
                },
               };
            return Rows;
        }
        private static List<Matrix_Element> GetMatrix()
        {
            var entries = new List<Matrix_Element>
            {
                new Matrix_Element{ 
					//Id = 1,
                    RowID = 1, ColID = 1,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					//Id = 2,
                    RowID = 1, ColID = 2,
                    cellValue = 1, R = "1"
                },
                new Matrix_Element{ 
					//Id = 3,
                    RowID = 1, ColID = 3,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					//Id = 4,
                    RowID = 1, ColID = 4,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{
					//Id = 5,
                    RowID = 1, ColID = 5,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					//Id = 6,
                    RowID = 2, ColID = 1,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					//Id = 7,
                    RowID = 2, ColID = 2,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					//Id = 8,
                    RowID = 2, ColID = 3,
                    cellValue = 1, R = "1"
                },
                new Matrix_Element{ 
					//Id = 9,
                    RowID = 2, ColID = 4,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					//Id = 10,
                    RowID = 2, ColID = 5,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					//Id = 11,
                    RowID = 3, ColID = 1,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					//Id = 12,
                    RowID = 3, ColID = 2,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					//Id = 13,
                    RowID = 3, ColID = 3,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					//Id = 14,
                    RowID = 3, ColID = 4,
                    cellValue = 1, R = "1"
                },
                new Matrix_Element{ 
					//Id = 15,
                    RowID = 3, ColID = 5,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					//Id = 16,
                    RowID = 4, ColID = 1,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					//Id = 17,
                    RowID = 4, ColID = 2,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					//Id = 18,
                    RowID = 4, ColID = 3,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					//Id = 19,
                    RowID = 4, ColID = 4,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					//Id = 20,
                    RowID = 4, ColID = 5,
                    cellValue = 1, R = "1"
                },
                new Matrix_Element{ 
					//Id = 21,
                    RowID = 5, ColID = 1,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					//Id = 22,
                    RowID = 5, ColID = 2,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					//Id = 23,
                    RowID = 5, ColID = 3,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					//Id = 24,
                    RowID = 5, ColID = 4,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					//Id = 25,
                    RowID = 5, ColID = 5,
                    cellValue = 0, R = "1"
                },

//=============Matrix R12 =============//
            
                new Matrix_Element{ 
					//Id = 26,
                    RowID = 1, ColID = 6,
                    cellValue = 1, R = "12"
                },
                new Matrix_Element{ 
					//Id = 27,
                    RowID = 1, ColID = 7,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					//Id = 28,
                    RowID = 1, ColID = 8,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					//Id = 29,
                    RowID = 1, ColID = 9,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					//Id = 30,
                    RowID = 1, ColID = 10,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					//Id = 31,
                    RowID = 1, ColID = 11,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					//Id = 32,
                    RowID = 2, ColID = 6,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					//Id = 33,
                    RowID = 2, ColID = 7,
                    cellValue = 1, R = "12"
                },
                new Matrix_Element{ 
					//Id = 34,
                    RowID = 2, ColID = 8,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					//Id = 35,
                    RowID = 2, ColID = 9,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					//Id = 36,
                    RowID = 2, ColID = 10,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					//Id = 37,
                    RowID = 2, ColID = 11,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					//Id = 38,
                    RowID = 3, ColID = 6,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					//Id = 39,
                    RowID = 3, ColID = 7,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					//Id = 40,
                    RowID = 3, ColID = 8,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					//Id = 41,
                    RowID = 3, ColID = 9,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					//Id = 42,
                    RowID = 3, ColID = 10,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					//Id = 43,
                    RowID = 3, ColID = 11,
                    cellValue = 1, R = "12"
                },
                new Matrix_Element{ 
					//Id = 44,
                    RowID = 4, ColID = 6,
                    cellValue = 1, R = "12"
                },
                new Matrix_Element{ 
					//Id = 45,
                    RowID = 4, ColID = 7,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					//Id = 46,
                    RowID = 4, ColID = 8,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					//Id = 47,
                    RowID = 4, ColID = 9,
                    cellValue = 1, R = "12"
                },
                new Matrix_Element{ 
					//Id = 48,
                    RowID = 4, ColID = 10,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					//Id = 49,
                    RowID = 4, ColID = 11,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					//Id = 50,
                    RowID = 5, ColID = 6,
                    cellValue = 1, R = "12"
                },
                new Matrix_Element{ 
					//Id = 51,
                    RowID = 5, ColID = 7,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					//Id = 52,
                    RowID = 5, ColID = 8,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					//Id = 53,
                    RowID = 5, ColID = 9,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					//Id = 54,
                    RowID = 5, ColID = 10,
                    cellValue = 0, R = "12"
                },     
                new Matrix_Element{ 
					//Id = 55,
                    RowID = 5, ColID = 11,
                    cellValue = 0, R = "12"
                },

//================Matrix R2 ===============//
                new Matrix_Element{ 
					//Id = 56,
                    RowID = 6, ColID = 6,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 57,
                    RowID = 6, ColID = 7,
                    cellValue = 1, R = "2"
                },
                new Matrix_Element{ 
					//Id = 58,
                    RowID = 6, ColID = 8,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 59,
                    RowID = 6, ColID = 9,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 60,
                    RowID = 6, ColID = 10,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 61,
                    RowID = 6, ColID = 11,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 62,
                    RowID = 7, ColID = 6,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 63,
                    RowID = 7, ColID = 7,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 64,
                    RowID = 7, ColID = 8,
                    cellValue = 1, R = "2"
                },
                new Matrix_Element{ 
					//Id = 65,
                    RowID = 7, ColID = 9,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{
					//Id = 66,
                    RowID = 7, ColID = 10,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 67,
                    RowID = 7, ColID = 11,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 68,
                    RowID = 8, ColID = 6,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 69,
                    RowID = 8, ColID = 7,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 70,
                    RowID = 8, ColID = 8,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 71,
                    RowID = 8, ColID = 9,
                    cellValue = 1, R = "2"
                },
                new Matrix_Element{ 
					//Id = 72,
                    RowID = 8, ColID = 10,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 73,
                    RowID = 8, ColID = 11,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 74,
                    RowID = 9, ColID = 6,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 75,
                    RowID = 9, ColID = 7,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 76,
                    RowID = 9, ColID = 8,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 77,
                    RowID = 9, ColID = 9,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{
					//Id = 78,
                    RowID = 9, ColID = 10,
                    cellValue = 1, R = "2"
                },
                new Matrix_Element{ 
					//Id = 79,
                    RowID = 9, ColID = 11,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 80,
                    RowID = 10, ColID = 6,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 81,
                    RowID = 10, ColID = 7,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{
					//Id = 82,
                    RowID = 10, ColID = 8,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 83,
                    RowID = 10, ColID = 9,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 84,
                    RowID = 10, ColID = 10,
                    cellValue = 0, R = "2"
                },     
                new Matrix_Element{ 
					//Id = 85,
                    RowID = 10, ColID = 11,
                    cellValue = 1, R = "2"
                },
                new Matrix_Element{ 
					//Id = 86,
                    RowID = 11, ColID = 6,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 87,
                    RowID = 11, ColID = 7,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 88,
                    RowID = 11, ColID = 8,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 89,
                    RowID = 11, ColID = 9,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					//Id = 90,
                    RowID = 11, ColID = 10,
                    cellValue = 0, R = "2"
                },     
                new Matrix_Element{ 
					//Id = 91,
                    RowID = 11, ColID = 11,
                    cellValue = 0, R = "2"
                },
//============== Matrix R23 ===============//
                new Matrix_Element{ 
					//Id = 92,
                    RowID = 6, ColID = 12,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 93,
                    RowID = 6, ColID = 13,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 94,
                    RowID = 6, ColID = 14,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 95,
                    RowID = 6, ColID = 15,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 96,
                    RowID = 6, ColID = 16,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 97,
                    RowID = 6, ColID = 17,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 98,
                    RowID = 6, ColID = 18,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 99,
                    RowID = 6, ColID = 19,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 100,
                    RowID = 6, ColID = 20,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 101,
                    RowID = 6, ColID = 21,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 102,
                    RowID = 6, ColID = 22,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 103,
                    RowID = 6, ColID = 23,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 104,
                    RowID = 6, ColID = 24,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 105,
                    RowID = 6, ColID = 25,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 106,
                    RowID = 6, ColID = 26,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 107,
                    RowID = 6, ColID = 27,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 108,
                    RowID = 6, ColID = 28,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 109,
                    RowID = 7, ColID = 12,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 110,
                    RowID = 7, ColID = 13,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{
					//Id = 111,
                    RowID = 7, ColID = 14,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 112,
                    RowID = 7, ColID = 15,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{
					//Id = 113,
                    RowID = 7, ColID = 16,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{
					//Id = 114,
                    RowID = 7, ColID = 17,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 115,
                    RowID = 7, ColID = 18,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 116,
                    RowID = 7, ColID = 19,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 117,
                    RowID = 7, ColID = 20,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 118,
                    RowID = 7, ColID = 21,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 119,
                    RowID = 7, ColID = 22,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 120,
                    RowID = 7, ColID = 23,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 121,
                    RowID = 7, ColID = 24,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 122,
                    RowID = 7, ColID = 25,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 123,
                    RowID = 7, ColID = 26,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 124,
                    RowID = 7, ColID = 27,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 125,
                    RowID = 7, ColID = 28,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 126,
                    RowID = 8, ColID = 12,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 127,
                    RowID = 8, ColID = 13,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 128,
                    RowID = 8, ColID = 14,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 129,
                    RowID = 8, ColID = 15,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 130,
                    RowID = 8, ColID = 16,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 131,
                    RowID = 8, ColID = 17,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 132,
                    RowID = 8, ColID = 18,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 133,
                    RowID = 8, ColID = 19,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 134,
                    RowID = 8, ColID = 20,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 135,
                    RowID = 8, ColID = 21,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 136,
                    RowID = 8, ColID = 22,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 137,
                    RowID = 8, ColID = 23,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 138,
                    RowID = 8, ColID = 24,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 139,
                    RowID = 8, ColID = 25,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 140,
                    RowID = 8, ColID = 26,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 141,
                    RowID = 8, ColID = 27,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 142,
                    RowID = 8, ColID = 28,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 143,
                    RowID = 9, ColID = 12,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 144,
                    RowID = 9, ColID = 13,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 145,
                    RowID = 9, ColID = 14,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 146,
                    RowID = 9, ColID = 15,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 147,
                    RowID = 9, ColID = 16,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 148,
                    RowID = 9, ColID = 17,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 149,
                    RowID = 9, ColID = 18,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 150,
                    RowID = 9, ColID = 19,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 151,
                    RowID = 9, ColID = 20,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 152,
                    RowID = 9, ColID = 21,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 153,
                    RowID = 9, ColID = 22,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 154,
                    RowID = 9, ColID = 23,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 155,
                    RowID = 9, ColID = 24,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 156,
                    RowID = 9, ColID = 25,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 157,
                    RowID = 9, ColID = 26,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 158,
                    RowID = 9, ColID = 27,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 159,
                    RowID = 9, ColID = 28,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 160,
                    RowID = 10, ColID = 12,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 161,
                    RowID = 10, ColID = 13,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 162,
                    RowID = 10, ColID = 14,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 163,
                    RowID = 10, ColID = 15,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 164,
                    RowID = 10, ColID = 16,
                    cellValue = 0, R = "23"
                },     
                new Matrix_Element{ 
					//Id = 165,
                    RowID = 10, ColID = 17,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 166,
                    RowID = 10, ColID = 18,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 167,
                    RowID = 10, ColID = 19,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 168,
                    RowID = 10, ColID = 20,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 169,
                    RowID = 10, ColID = 21,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 170,
                    RowID = 10, ColID = 22,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 171,
                    RowID = 10, ColID = 23,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 172,
                    RowID = 10, ColID = 24,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 173,
                    RowID = 10, ColID = 25,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 174,
                    RowID = 10, ColID = 26,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 175,
                    RowID = 10, ColID = 27,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 176,
                    RowID = 10, ColID = 28,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 177,
                    RowID = 11, ColID = 12,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 178,
                    RowID = 11, ColID = 13,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 179,
                    RowID = 11, ColID = 14,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 180,
                    RowID = 11, ColID = 15,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 181,
                    RowID = 11, ColID = 16,
                    cellValue = 0, R = "23"
                },     
                new Matrix_Element{ 
					//Id = 182,
                    RowID = 11, ColID = 17,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 183,
                    RowID = 11, ColID = 18,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 184,
                    RowID = 11, ColID = 19,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 185,
                    RowID = 11, ColID = 20,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 186,
                    RowID = 11, ColID = 21,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 187,
                    RowID = 11, ColID = 22,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					//Id = 188,
                    RowID = 11, ColID = 23,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 189,
                    RowID = 11, ColID = 24,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 190,
                    RowID = 11, ColID = 25,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 191,
                    RowID = 11, ColID = 26,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 192,
                    RowID = 11, ColID = 27,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					//Id = 193,
                    RowID = 11, ColID = 28,
                    cellValue = 1, R = "23"
                },
//==============Matrix R3 =================//
                new Matrix_Element{ 
					//Id = 194,
                    RowID = 12, ColID = 12,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 195,
                    RowID = 12, ColID = 13,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 196,
                    RowID = 12, ColID = 14,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 197,
                    RowID = 12, ColID = 15,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 198,
                    RowID = 12, ColID = 16,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 199,
                    RowID = 12, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 200,
                    RowID = 12, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 201,
                    RowID = 12, ColID = 19,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 202,
                    RowID = 12, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 203,
                    RowID = 12, ColID = 21,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 204,
                    RowID = 12, ColID = 22,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 205,
                    RowID = 12, ColID = 23,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 206,
                    RowID = 12, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 207,
                    RowID = 12, ColID = 25,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 208,
                    RowID = 12, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 209,
                    RowID = 12, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 210,
                    RowID = 12, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 211,
                    RowID = 13, ColID = 12,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 212,
                    RowID = 13, ColID = 13,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 213,
                    RowID = 13, ColID = 14,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 214,
                    RowID = 13, ColID = 15,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 215,
                    RowID = 13, ColID = 16,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 216,
                    RowID = 13, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 217,
                    RowID = 13, ColID = 18,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 218,
                    RowID = 13, ColID = 19,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 219,
                    RowID = 13, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 220,
                    RowID = 13, ColID = 21,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 221,
                    RowID = 13, ColID = 22,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 222,
                    RowID = 13, ColID = 23,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 223,
                    RowID = 13, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 224,
                    RowID = 13, ColID = 25,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 225,
                    RowID = 13, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 226,
                    RowID = 13, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 227,
                    RowID = 13, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 228,
                    RowID = 14, ColID = 12,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 229,
                    RowID = 14, ColID = 13,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 230,
                    RowID = 14, ColID = 14,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 231,
                    RowID = 14, ColID = 15,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 232,
                    RowID = 14, ColID = 16,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 233,
                    RowID = 14, ColID = 17,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 234,
                    RowID = 14, ColID = 18,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 235,
                    RowID = 14, ColID = 19,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 236,
                    RowID = 14, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 237,
                    RowID = 14, ColID = 21,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 238,
                    RowID = 14, ColID = 22,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 239,
                    RowID = 14, ColID = 23,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 240,
                    RowID = 14, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 241,
                    RowID = 14, ColID = 25,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 242,
                    RowID = 14, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 243,
                    RowID = 14, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 244,
                    RowID = 14, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 245,
                    RowID = 15, ColID = 12,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 246,
                    RowID = 15, ColID = 13,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 247,
                    RowID = 15, ColID = 14,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					//Id = 248,
                    RowID = 15, ColID = 15,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 249,
                    RowID = 15, ColID = 16,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 250,
                    RowID = 15, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 251,
                    RowID = 15, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 252,
                    RowID = 15, ColID = 19,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					//Id = 253,
                    RowID = 15, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 254,
                    RowID = 15, ColID = 21,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 255,
                    RowID = 15, ColID = 22,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 256,
                    RowID = 15, ColID = 23,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 257,
                    RowID = 15, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 258,
                    RowID = 15, ColID = 25,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 259,
                    RowID = 15, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 260,
                    RowID = 15, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 261,
                    RowID = 15, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 262,
                    RowID = 16, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 263,
                    RowID = 16, ColID = 13,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					//Id = 264,
                    RowID = 16, ColID = 14,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 265,
                    RowID = 16, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 266,
                    RowID = 16, ColID = 16,
                    cellValue = 0, R = "3"
                },     
                new Matrix_Element{ 
					//Id = 267,
                    RowID = 16, ColID = 17,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					//Id = 268,
                    RowID = 16, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 269,
                    RowID = 16, ColID = 19,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 270,
                    RowID = 16, ColID = 20,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 271,
                    RowID = 16, ColID = 21,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 272,
                    RowID = 16, ColID = 22,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 273,
                    RowID = 16, ColID = 23,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 274,
                    RowID = 16, ColID = 24,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 275,
                    RowID = 16, ColID = 25,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 276,
                    RowID = 16, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 277,
                    RowID = 16, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 278,
                    RowID = 16, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 279,
                    RowID = 17, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 280,
                    RowID = 17, ColID = 13,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 281,
                    RowID = 17, ColID = 14,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 282,
                    RowID = 17, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 283,
                    RowID = 17, ColID = 16,
                    cellValue = 0, R = "3"
                },     
                new Matrix_Element{
					//Id = 284,
                    RowID = 17, ColID = 17,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 285,
                    RowID = 17, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 286,
                    RowID = 17, ColID = 19,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 287,
                    RowID = 17, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 288,
                    RowID = 17, ColID = 21,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 289,
                    RowID = 17, ColID = 22,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 290,
                    RowID = 17, ColID = 23,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 291,
                    RowID = 17, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 292,
                    RowID = 17, ColID = 25,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 293,
                    RowID = 17, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 294,
                    RowID = 17, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 295,
                    RowID = 17, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 296,
                    RowID = 18, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 297,
                    RowID = 18, ColID = 13,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 298,
                    RowID = 18, ColID = 14,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 299,
                    RowID = 18, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 300,
                    RowID = 18, ColID = 16,
                    cellValue = 1, R = "3"
                },     
                new Matrix_Element{ 
					//Id = 301,
                    RowID = 18, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 302,
                    RowID = 18, ColID = 18,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 303,
                    RowID = 18, ColID = 19,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 304,
                    RowID = 18, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 305,
                    RowID = 18, ColID = 21,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 306,
                    RowID = 18, ColID = 22,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 307,
                    RowID = 18, ColID = 23,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 308,
                    RowID = 18, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 309,
                    RowID = 18, ColID = 25,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 310,
                    RowID = 18, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 311,
                    RowID = 18, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 312,
                    RowID = 18, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 313,
                    RowID = 19, ColID = 12,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 314,
                    RowID = 19, ColID = 13,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 315,
                    RowID = 19, ColID = 14,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 316,
                    RowID = 19, ColID = 15,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					//Id = 317,
                    RowID = 19, ColID = 16,
                    cellValue = 0, R = "3"
                },     
                new Matrix_Element{
					//Id = 318,
                    RowID = 19, ColID = 17,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 319,
                    RowID = 19, ColID = 18,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					//Id = 320,
                    RowID = 19, ColID = 19,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 321,
                    RowID = 19, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 322,
                    RowID = 19, ColID = 21,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 323,
                    RowID = 19, ColID = 22,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					//Id = 324,
                    RowID = 19, ColID = 23,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 325,
                    RowID = 19, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 326,
                    RowID = 19, ColID = 25,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 327,
                    RowID = 19, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 328,
                    RowID = 19, ColID = 27,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					//Id = 329,
                    RowID = 19, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 330,
                    RowID = 20, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 331,
                    RowID = 20, ColID = 13,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 332,
                    RowID = 20, ColID = 14,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 333,
                    RowID = 20, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 334,
                    RowID = 20, ColID = 16,
                    cellValue = 0, R = "3"
                },     
                new Matrix_Element{ 
					//Id = 335,
                    RowID = 20, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 336,
                    RowID = 20, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 337,
                    RowID = 20, ColID = 19,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 338,
                    RowID = 20, ColID = 20,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					//Id = 339,
                    RowID = 20, ColID = 21,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 340,
                    RowID = 20, ColID = 22,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 341,
                    RowID = 20, ColID = 23,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 342,
                    RowID = 20, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 343,
                    RowID = 20, ColID = 25,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 344,
                    RowID = 20, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 345,
                    RowID = 20, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 346,
                    RowID = 20, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 347,
                    RowID = 21, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 348,
                    RowID = 21, ColID = 13,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					//Id = 349,
                    RowID = 21, ColID = 14,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 350,
                    RowID = 21, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 351,
                    RowID = 21, ColID = 16,
                    cellValue = 1, R = "3"
                },     
                new Matrix_Element{ 
					//Id = 352,
                    RowID = 21, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 353,
                    RowID = 21, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 354,
                    RowID = 21, ColID = 19,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 355,
                    RowID = 21, ColID = 20,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 356,
                    RowID = 21, ColID = 21,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					//Id = 357,
                    RowID = 21, ColID = 22,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 358,
                    RowID = 21, ColID = 23,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 359,
                    RowID = 21, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 360,
                    RowID = 21, ColID = 25,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 361,
                    RowID = 21, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 362,
                    RowID = 21, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 363,
                    RowID = 21, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 364,
                    RowID = 22, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 365,
                    RowID = 22, ColID = 13,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 366,
                    RowID = 22, ColID = 14,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 367,
                    RowID = 22, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 368,
                    RowID = 22, ColID = 16,
                    cellValue = 1, R = "3"
                },     
                new Matrix_Element{
					//Id = 369,
                    RowID = 22, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 370,
                    RowID = 22, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 371,
                    RowID = 22, ColID = 19,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 372,
                    RowID = 22, ColID = 20,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 373,
                    RowID = 22, ColID = 21,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 374,
                    RowID = 22, ColID = 22,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 375,
                    RowID = 22, ColID = 23,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 376,
                    RowID = 22, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 377,
                    RowID = 22, ColID = 25,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 378,
                    RowID = 22, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 379,
                    RowID = 22, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 380,
                    RowID = 22, ColID = 28,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 381,
                    RowID = 23, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 382,
                    RowID = 23, ColID = 13,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 383,
                    RowID = 23, ColID = 14,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 384,
                    RowID = 23, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 385,
                    RowID = 23, ColID = 16,
                    cellValue = 1, R = "3"
                },     
                new Matrix_Element{ 
					//Id = 386,
                    RowID = 23, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 387,
                    RowID = 23, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 388,
                    RowID = 23, ColID = 19,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 389,
                    RowID = 23, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 390,
                    RowID = 23, ColID = 21,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 391,
                    RowID = 23, ColID = 22,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 392,
                    RowID = 23, ColID = 23,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 393,
                    RowID = 23, ColID = 24,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 394,
                    RowID = 23, ColID = 25,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 395,
                    RowID = 23, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 396,
                    RowID = 23, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 397,
                    RowID = 23, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 398,
                    RowID = 24, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 399,
                    RowID = 24, ColID = 13,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 400,
                    RowID = 24, ColID = 14,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 401,
                    RowID = 24, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 402,
                    RowID = 24, ColID = 16,
                    cellValue = 0, R = "3"
                },     
                new Matrix_Element{ 
					//Id = 403,
                    RowID = 24, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 404,
                    RowID = 24, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 405,
                    RowID = 24, ColID = 19,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 406,
                    RowID = 24, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 407,
                    RowID = 24, ColID = 21,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 408,
                    RowID = 24, ColID = 22,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 409,
                    RowID = 24, ColID = 23,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 410,
                    RowID = 24, ColID = 24,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 411,
                    RowID = 24, ColID = 25,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 412,
                    RowID = 24, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 413,
                    RowID = 24, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 414,
                    RowID = 24, ColID = 28,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 415,
                    RowID = 25, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 416,
                    RowID = 25, ColID = 13,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 417,
                    RowID = 25, ColID = 14,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 418,
                    RowID = 25, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 419,
                    RowID = 25, ColID = 16,
                    cellValue = 1, R = "3"
                },     
                new Matrix_Element{ 
					//Id = 420,
                    RowID = 25, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 421,
                    RowID = 25, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 422,
                    RowID = 25, ColID = 19,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 423,
                    RowID = 25, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 424,
                    RowID = 25, ColID = 21,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 425,
                    RowID = 25, ColID = 22,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 426,
                    RowID = 25, ColID = 23,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 427,
                    RowID = 25, ColID = 24,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 428,
                    RowID = 25, ColID = 25,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 429,
                    RowID = 25, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 430,
                    RowID = 25, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 431,
                    RowID = 25, ColID = 28,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 432,
                    RowID = 26, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 433,
                    RowID = 26, ColID = 13,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 434,
                    RowID = 26, ColID = 14,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 435,
                    RowID = 26, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 436,
                    RowID = 26, ColID = 16,
                    cellValue = 1, R = "3"
                },     
                new Matrix_Element{ 
					//Id = 437,
                    RowID = 26, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 438,
                    RowID = 26, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 439,
                    RowID = 26, ColID = 19,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 440,
                    RowID = 26, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 441,
                    RowID = 26, ColID = 21,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 442,
                    RowID = 26, ColID = 22,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 443,
                    RowID = 26, ColID = 23,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 444,
                    RowID = 26, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 445,
                    RowID = 26, ColID = 25,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 446,
                    RowID = 26, ColID = 26,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 447,
                    RowID = 26, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 448,
                    RowID = 26, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 449,
                    RowID = 27, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 450,
                    RowID = 27, ColID = 13,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 451,
                    RowID = 27, ColID = 14,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 452,
                    RowID = 27, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 453,
                    RowID = 27, ColID = 16,
                    cellValue = 1, R = "3"
                },     
                new Matrix_Element{ 
					//Id = 454,
                    RowID = 27, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 455,
                    RowID = 27, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 456,
                    RowID = 27, ColID = 19,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 457,
                    RowID = 27, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 458,
                    RowID = 27, ColID = 21,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 459,
                    RowID = 27, ColID = 22,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 460,
                    RowID = 27, ColID = 23,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 461,
                    RowID = 27, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 462,
                    RowID = 27, ColID = 25,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 463,
                    RowID = 27, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 464,
                    RowID = 27, ColID = 27,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					//Id = 465,
                    RowID = 27, ColID = 28,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 466,
                    RowID = 28, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 467,
                    RowID = 28, ColID = 13,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 468,
                    RowID = 28, ColID = 14,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 469,
                    RowID = 28, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 470,
                    RowID = 28, ColID = 16,
                    cellValue = 1, R = "3"
                },     
                new Matrix_Element{
					//Id = 471,
                    RowID = 28, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					//Id = 472,
                    RowID = 28, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 473,
                    RowID = 28, ColID = 19,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 474,
                    RowID = 28, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 475,
                    RowID = 28, ColID = 21,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 476,
                    RowID = 28, ColID = 22,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 477,
                    RowID = 28, ColID = 23,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 478,
                    RowID = 28, ColID = 24,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 479,
                    RowID = 28, ColID = 25,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 480,
                    RowID = 28, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					//Id = 481,
                    RowID = 28, ColID = 27,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					//Id = 482,
                    RowID = 28, ColID = 28,
                    cellValue = 0, R = "3"
                },
//================= Matrix R34 ==============//
                new Matrix_Element{ 
					//Id = 483,
                    RowID = 12, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 484,
                    RowID = 12, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 485,
                    RowID = 12, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 486,
                    RowID = 12, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 487,
                    RowID = 12, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 493,
                    RowID = 13, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 494,
                    RowID = 13, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 495,
                    RowID = 13, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					//Id = 496,
                    RowID = 13, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 497,
                    RowID = 13, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 498,
                    RowID = 14, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 499,
                    RowID = 14, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 500,
                    RowID = 14, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 501,
                    RowID = 14, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 502,
                    RowID = 14, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 503,
                    RowID = 15, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 504,
                    RowID = 15, ColID = 30,
                    cellValue = 0, R = "34"
                },
                new Matrix_Element{
					//Id = 505,
                    RowID = 15, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 506,
                    RowID = 15, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 507,
                    RowID = 15, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 508,
                    RowID = 16, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 509,
                    RowID = 16, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 510,
                    RowID = 16, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					//Id = 511,
                    RowID = 16, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 512,
                    RowID = 16, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 513,
                    RowID = 17, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 514,
                    RowID = 17, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 515,
                    RowID = 17, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 516,
                    RowID = 17, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 517,
                    RowID = 17, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 518,
                    RowID = 18, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 519,
                    RowID = 18, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 520,
                    RowID = 18, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 521,
                    RowID = 18, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 522,
                    RowID = 18, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					//Id = 523,
                    RowID = 19, ColID = 29,
                    cellValue = 0, R = "34"
                },
                new Matrix_Element{ 
					//Id = 524,
                    RowID = 19, ColID = 30,
                    cellValue = 0, R = "34"
                },
                new Matrix_Element{ 
					//Id = 525,
                    RowID = 19, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 526,
                    RowID = 19, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					//Id = 527,
                    RowID = 19, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					//Id = 528,
                    RowID = 20, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 529,
                    RowID = 20, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 530,
                    RowID = 20, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 531,
                    RowID = 20, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 532,
                    RowID = 20, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					//Id = 533,
                    RowID = 21, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					//Id = 534,
                    RowID = 21, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 535,
                    RowID = 21, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					//Id = 536,
                    RowID = 21, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					//Id = 537,
                    RowID = 21, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 538,
                    RowID = 22, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 539,
                    RowID = 22, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 540,
                    RowID = 22, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 541,
                    RowID = 22, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					//Id = 542,
                    RowID = 22, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 543,
                    RowID = 23, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 544,
                    RowID = 23, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 545,
                    RowID = 23, ColID = 31,
                    cellValue = 0, R = "34"
                },
                new Matrix_Element{ 
					//Id = 546,
                    RowID = 23, ColID = 32,
                    cellValue = 0, R = "34"
                },
                new Matrix_Element{ 
					//Id = 547,
                    RowID = 23, ColID = 33,
                    cellValue = 0, R = "34"
                },
                new Matrix_Element{ 
					//Id = 548,
                    RowID = 24, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 549,
                    RowID = 24, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 550,
                    RowID = 24, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 551,
                    RowID = 24, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					//Id = 552,
                    RowID = 24, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 553,
                    RowID = 25, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 554,
                    RowID = 25, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 555,
                    RowID = 25, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 556,
                    RowID = 25, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 557,
                    RowID = 25, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 558,
                    RowID = 26, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 559,
                    RowID = 26, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					//Id = 560,
                    RowID = 26, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 561,
                    RowID = 26, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 562,
                    RowID = 26, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 563,
                    RowID = 27, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 564,
                    RowID = 27, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 565,
                    RowID = 27, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 566,
                    RowID = 27, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 567,
                    RowID = 27, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 568,
                    RowID = 28, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 569,
                    RowID = 28, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 570,
                    RowID = 28, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 571,
                    RowID = 28, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					//Id = 572,
                    RowID = 28, ColID = 33,
                    cellValue = 1, R = "34"
                },
            };
            return entries;
        }
    }
}
