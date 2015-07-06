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
            //GetMatrix().ForEach(a => context.default_Matrix.Add(a));
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
					ElementID = 1,
                    RowID = 1, ColID = 1,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					ElementID = 2,
                    RowID = 1, ColID = 2,
                    cellValue = 1, R = "1"
                },
                new Matrix_Element{ 
					ElementID = 3,
                    RowID = 1, ColID = 3,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					ElementID = 4,
                    RowID = 1, ColID = 4,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{
					ElementID = 5,
                    RowID = 1, ColID = 5,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					ElementID = 6,
                    RowID = 2, ColID = 1,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					ElementID = 7,
                    RowID = 2, ColID = 2,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					ElementID = 8,
                    RowID = 2, ColID = 3,
                    cellValue = 1, R = "1"
                },
                new Matrix_Element{ 
					ElementID = 9,
                    RowID = 2, ColID = 4,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					ElementID = 10,
                    RowID = 2, ColID = 5,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					ElementID = 11,
                    RowID = 3, ColID = 1,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					ElementID = 12,
                    RowID = 3, ColID = 2,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					ElementID = 13,
                    RowID = 3, ColID = 3,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					ElementID = 14,
                    RowID = 3, ColID = 4,
                    cellValue = 1, R = "1"
                },
                new Matrix_Element{ 
					ElementID = 15,
                    RowID = 3, ColID = 5,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					ElementID = 16,
                    RowID = 4, ColID = 1,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					ElementID = 17,
                    RowID = 4, ColID = 2,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					ElementID = 18,
                    RowID = 4, ColID = 3,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					ElementID = 19,
                    RowID = 4, ColID = 4,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					ElementID = 20,
                    RowID = 4, ColID = 5,
                    cellValue = 1, R = "1"
                },
                new Matrix_Element{ 
					ElementID = 21,
                    RowID = 5, ColID = 1,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					ElementID = 22,
                    RowID = 5, ColID = 2,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					ElementID = 23,
                    RowID = 5, ColID = 3,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					ElementID = 24,
                    RowID = 5, ColID = 4,
                    cellValue = 0, R = "1"
                },
                new Matrix_Element{ 
					ElementID = 25,
                    RowID = 5, ColID = 5,
                    cellValue = 0, R = "1"
                },

//=============Matrix R12 =============//
            
                new Matrix_Element{ 
					ElementID = 26,
                    RowID = 1, ColID = 6,
                    cellValue = 1, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 27,
                    RowID = 1, ColID = 7,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 28,
                    RowID = 1, ColID = 8,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 29,
                    RowID = 1, ColID = 9,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 30,
                    RowID = 1, ColID = 10,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 31,
                    RowID = 1, ColID = 11,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 32,
                    RowID = 2, ColID = 6,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 33,
                    RowID = 2, ColID = 7,
                    cellValue = 1, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 34,
                    RowID = 2, ColID = 8,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 35,
                    RowID = 2, ColID = 9,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 36,
                    RowID = 2, ColID = 10,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 37,
                    RowID = 2, ColID = 11,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 38,
                    RowID = 3, ColID = 6,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 39,
                    RowID = 3, ColID = 7,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 40,
                    RowID = 3, ColID = 8,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 41,
                    RowID = 3, ColID = 9,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 42,
                    RowID = 3, ColID = 10,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 43,
                    RowID = 3, ColID = 11,
                    cellValue = 1, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 44,
                    RowID = 4, ColID = 6,
                    cellValue = 1, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 45,
                    RowID = 4, ColID = 7,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 46,
                    RowID = 4, ColID = 8,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 47,
                    RowID = 4, ColID = 9,
                    cellValue = 1, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 48,
                    RowID = 4, ColID = 10,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 49,
                    RowID = 4, ColID = 11,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 50,
                    RowID = 5, ColID = 6,
                    cellValue = 1, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 51,
                    RowID = 5, ColID = 7,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 52,
                    RowID = 5, ColID = 8,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 53,
                    RowID = 5, ColID = 9,
                    cellValue = 0, R = "12"
                },
                new Matrix_Element{ 
					ElementID = 54,
                    RowID = 5, ColID = 10,
                    cellValue = 0, R = "12"
                },     
                new Matrix_Element{ 
					ElementID = 55,
                    RowID = 5, ColID = 11,
                    cellValue = 0, R = "12"
                },

//================Matrix R2 ===============//
                new Matrix_Element{ 
					ElementID = 56,
                    RowID = 6, ColID = 6,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 57,
                    RowID = 6, ColID = 7,
                    cellValue = 1, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 58,
                    RowID = 6, ColID = 8,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 59,
                    RowID = 6, ColID = 9,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 60,
                    RowID = 6, ColID = 10,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 61,
                    RowID = 6, ColID = 11,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 62,
                    RowID = 7, ColID = 6,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 63,
                    RowID = 7, ColID = 7,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 64,
                    RowID = 7, ColID = 8,
                    cellValue = 1, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 65,
                    RowID = 7, ColID = 9,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{
					ElementID = 66,
                    RowID = 7, ColID = 10,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 67,
                    RowID = 7, ColID = 11,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 68,
                    RowID = 8, ColID = 6,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 69,
                    RowID = 8, ColID = 7,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 70,
                    RowID = 8, ColID = 8,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 71,
                    RowID = 8, ColID = 9,
                    cellValue = 1, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 72,
                    RowID = 8, ColID = 10,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 73,
                    RowID = 8, ColID = 11,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 74,
                    RowID = 9, ColID = 6,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 75,
                    RowID = 9, ColID = 7,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 76,
                    RowID = 9, ColID = 8,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 77,
                    RowID = 9, ColID = 9,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{
					ElementID = 78,
                    RowID = 9, ColID = 10,
                    cellValue = 1, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 79,
                    RowID = 9, ColID = 11,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 80,
                    RowID = 10, ColID = 6,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 81,
                    RowID = 10, ColID = 7,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{
					ElementID = 82,
                    RowID = 10, ColID = 8,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 83,
                    RowID = 10, ColID = 9,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 84,
                    RowID = 10, ColID = 10,
                    cellValue = 0, R = "2"
                },     
                new Matrix_Element{ 
					ElementID = 85,
                    RowID = 10, ColID = 11,
                    cellValue = 1, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 86,
                    RowID = 11, ColID = 6,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 87,
                    RowID = 11, ColID = 7,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 88,
                    RowID = 11, ColID = 8,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 89,
                    RowID = 11, ColID = 9,
                    cellValue = 0, R = "2"
                },
                new Matrix_Element{ 
					ElementID = 90,
                    RowID = 11, ColID = 10,
                    cellValue = 0, R = "2"
                },     
                new Matrix_Element{ 
					ElementID = 91,
                    RowID = 11, ColID = 11,
                    cellValue = 0, R = "2"
                },
//============== Matrix R23 ===============//
                new Matrix_Element{ 
					ElementID = 92,
                    RowID = 6, ColID = 12,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 93,
                    RowID = 6, ColID = 13,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 94,
                    RowID = 6, ColID = 14,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 95,
                    RowID = 6, ColID = 15,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 96,
                    RowID = 6, ColID = 16,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 97,
                    RowID = 6, ColID = 17,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 98,
                    RowID = 6, ColID = 18,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 99,
                    RowID = 6, ColID = 19,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 100,
                    RowID = 6, ColID = 20,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 101,
                    RowID = 6, ColID = 21,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 102,
                    RowID = 6, ColID = 22,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 103,
                    RowID = 6, ColID = 23,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 104,
                    RowID = 6, ColID = 24,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 105,
                    RowID = 6, ColID = 25,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 106,
                    RowID = 6, ColID = 26,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 107,
                    RowID = 6, ColID = 27,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 108,
                    RowID = 6, ColID = 28,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 109,
                    RowID = 7, ColID = 12,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 110,
                    RowID = 7, ColID = 13,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{
					ElementID = 111,
                    RowID = 7, ColID = 14,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 112,
                    RowID = 7, ColID = 15,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{
					ElementID = 113,
                    RowID = 7, ColID = 16,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{
					ElementID = 114,
                    RowID = 7, ColID = 17,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 115,
                    RowID = 7, ColID = 18,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 116,
                    RowID = 7, ColID = 19,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 117,
                    RowID = 7, ColID = 20,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 118,
                    RowID = 7, ColID = 21,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 119,
                    RowID = 7, ColID = 22,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 120,
                    RowID = 7, ColID = 23,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 121,
                    RowID = 7, ColID = 24,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 122,
                    RowID = 7, ColID = 25,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 123,
                    RowID = 7, ColID = 26,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 124,
                    RowID = 7, ColID = 27,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 125,
                    RowID = 7, ColID = 28,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 126,
                    RowID = 8, ColID = 12,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 127,
                    RowID = 8, ColID = 13,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 128,
                    RowID = 8, ColID = 14,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 129,
                    RowID = 8, ColID = 15,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 130,
                    RowID = 8, ColID = 16,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 131,
                    RowID = 8, ColID = 17,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 132,
                    RowID = 8, ColID = 18,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 133,
                    RowID = 8, ColID = 19,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 134,
                    RowID = 8, ColID = 20,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 135,
                    RowID = 8, ColID = 21,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 136,
                    RowID = 8, ColID = 22,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 137,
                    RowID = 8, ColID = 23,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 138,
                    RowID = 8, ColID = 24,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 139,
                    RowID = 8, ColID = 25,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 140,
                    RowID = 8, ColID = 26,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 141,
                    RowID = 8, ColID = 27,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 142,
                    RowID = 8, ColID = 28,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 143,
                    RowID = 9, ColID = 12,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 144,
                    RowID = 9, ColID = 13,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 145,
                    RowID = 9, ColID = 14,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 146,
                    RowID = 9, ColID = 15,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 147,
                    RowID = 9, ColID = 16,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 148,
                    RowID = 9, ColID = 17,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 149,
                    RowID = 9, ColID = 18,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 150,
                    RowID = 9, ColID = 19,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 151,
                    RowID = 9, ColID = 20,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 152,
                    RowID = 9, ColID = 21,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 153,
                    RowID = 9, ColID = 22,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 154,
                    RowID = 9, ColID = 23,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 155,
                    RowID = 9, ColID = 24,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 156,
                    RowID = 9, ColID = 25,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 157,
                    RowID = 9, ColID = 26,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 158,
                    RowID = 9, ColID = 27,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 159,
                    RowID = 9, ColID = 28,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 160,
                    RowID = 10, ColID = 12,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 161,
                    RowID = 10, ColID = 13,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 162,
                    RowID = 10, ColID = 14,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 163,
                    RowID = 10, ColID = 15,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 164,
                    RowID = 10, ColID = 16,
                    cellValue = 0, R = "23"
                },     
                new Matrix_Element{ 
					ElementID = 165,
                    RowID = 10, ColID = 17,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 166,
                    RowID = 10, ColID = 18,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 167,
                    RowID = 10, ColID = 19,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 168,
                    RowID = 10, ColID = 20,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 169,
                    RowID = 10, ColID = 21,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 170,
                    RowID = 10, ColID = 22,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 171,
                    RowID = 10, ColID = 23,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 172,
                    RowID = 10, ColID = 24,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 173,
                    RowID = 10, ColID = 25,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 174,
                    RowID = 10, ColID = 26,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 175,
                    RowID = 10, ColID = 27,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 176,
                    RowID = 10, ColID = 28,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 177,
                    RowID = 11, ColID = 12,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 178,
                    RowID = 11, ColID = 13,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 179,
                    RowID = 11, ColID = 14,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 180,
                    RowID = 11, ColID = 15,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 181,
                    RowID = 11, ColID = 16,
                    cellValue = 0, R = "23"
                },     
                new Matrix_Element{ 
					ElementID = 182,
                    RowID = 11, ColID = 17,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 183,
                    RowID = 11, ColID = 18,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 184,
                    RowID = 11, ColID = 19,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 185,
                    RowID = 11, ColID = 20,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 186,
                    RowID = 11, ColID = 21,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 187,
                    RowID = 11, ColID = 22,
                    cellValue = 0, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 188,
                    RowID = 11, ColID = 23,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 189,
                    RowID = 11, ColID = 24,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 190,
                    RowID = 11, ColID = 25,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 191,
                    RowID = 11, ColID = 26,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 192,
                    RowID = 11, ColID = 27,
                    cellValue = 1, R = "23"
                },
                new Matrix_Element{ 
					ElementID = 193,
                    RowID = 11, ColID = 28,
                    cellValue = 1, R = "23"
                },
//==============Matrix R3 =================//
                new Matrix_Element{ 
					ElementID = 194,
                    RowID = 12, ColID = 12,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 195,
                    RowID = 12, ColID = 13,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 196,
                    RowID = 12, ColID = 14,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 197,
                    RowID = 12, ColID = 15,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 198,
                    RowID = 12, ColID = 16,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 199,
                    RowID = 12, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 200,
                    RowID = 12, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 201,
                    RowID = 12, ColID = 19,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 202,
                    RowID = 12, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 203,
                    RowID = 12, ColID = 21,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 204,
                    RowID = 12, ColID = 22,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 205,
                    RowID = 12, ColID = 23,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 206,
                    RowID = 12, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 207,
                    RowID = 12, ColID = 25,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 208,
                    RowID = 12, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 209,
                    RowID = 12, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 210,
                    RowID = 12, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 211,
                    RowID = 13, ColID = 12,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 212,
                    RowID = 13, ColID = 13,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 213,
                    RowID = 13, ColID = 14,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 214,
                    RowID = 13, ColID = 15,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 215,
                    RowID = 13, ColID = 16,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 216,
                    RowID = 13, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 217,
                    RowID = 13, ColID = 18,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 218,
                    RowID = 13, ColID = 19,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 219,
                    RowID = 13, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 220,
                    RowID = 13, ColID = 21,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 221,
                    RowID = 13, ColID = 22,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 222,
                    RowID = 13, ColID = 23,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 223,
                    RowID = 13, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 224,
                    RowID = 13, ColID = 25,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 225,
                    RowID = 13, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 226,
                    RowID = 13, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 227,
                    RowID = 13, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 228,
                    RowID = 14, ColID = 12,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 229,
                    RowID = 14, ColID = 13,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 230,
                    RowID = 14, ColID = 14,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 231,
                    RowID = 14, ColID = 15,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 232,
                    RowID = 14, ColID = 16,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 233,
                    RowID = 14, ColID = 17,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 234,
                    RowID = 14, ColID = 18,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 235,
                    RowID = 14, ColID = 19,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 236,
                    RowID = 14, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 237,
                    RowID = 14, ColID = 21,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 238,
                    RowID = 14, ColID = 22,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 239,
                    RowID = 14, ColID = 23,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 240,
                    RowID = 14, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 241,
                    RowID = 14, ColID = 25,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 242,
                    RowID = 14, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 243,
                    RowID = 14, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 244,
                    RowID = 14, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 245,
                    RowID = 15, ColID = 12,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 246,
                    RowID = 15, ColID = 13,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 247,
                    RowID = 15, ColID = 14,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					ElementID = 248,
                    RowID = 15, ColID = 15,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 249,
                    RowID = 15, ColID = 16,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 250,
                    RowID = 15, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 251,
                    RowID = 15, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 252,
                    RowID = 15, ColID = 19,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					ElementID = 253,
                    RowID = 15, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 254,
                    RowID = 15, ColID = 21,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 255,
                    RowID = 15, ColID = 22,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 256,
                    RowID = 15, ColID = 23,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 257,
                    RowID = 15, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 258,
                    RowID = 15, ColID = 25,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 259,
                    RowID = 15, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 260,
                    RowID = 15, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 261,
                    RowID = 15, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 262,
                    RowID = 16, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 263,
                    RowID = 16, ColID = 13,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					ElementID = 264,
                    RowID = 16, ColID = 14,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 265,
                    RowID = 16, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 266,
                    RowID = 16, ColID = 16,
                    cellValue = 0, R = "3"
                },     
                new Matrix_Element{ 
					ElementID = 267,
                    RowID = 16, ColID = 17,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					ElementID = 268,
                    RowID = 16, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 269,
                    RowID = 16, ColID = 19,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 270,
                    RowID = 16, ColID = 20,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 271,
                    RowID = 16, ColID = 21,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 272,
                    RowID = 16, ColID = 22,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 273,
                    RowID = 16, ColID = 23,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 274,
                    RowID = 16, ColID = 24,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 275,
                    RowID = 16, ColID = 25,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 276,
                    RowID = 16, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 277,
                    RowID = 16, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 278,
                    RowID = 16, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 279,
                    RowID = 17, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 280,
                    RowID = 17, ColID = 13,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 281,
                    RowID = 17, ColID = 14,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 282,
                    RowID = 17, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 283,
                    RowID = 17, ColID = 16,
                    cellValue = 0, R = "3"
                },     
                new Matrix_Element{
					ElementID = 284,
                    RowID = 17, ColID = 17,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 285,
                    RowID = 17, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 286,
                    RowID = 17, ColID = 19,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 287,
                    RowID = 17, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 288,
                    RowID = 17, ColID = 21,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 289,
                    RowID = 17, ColID = 22,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 290,
                    RowID = 17, ColID = 23,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 291,
                    RowID = 17, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 292,
                    RowID = 17, ColID = 25,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 293,
                    RowID = 17, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 294,
                    RowID = 17, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 295,
                    RowID = 17, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 296,
                    RowID = 18, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 297,
                    RowID = 18, ColID = 13,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 298,
                    RowID = 18, ColID = 14,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 299,
                    RowID = 18, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 300,
                    RowID = 18, ColID = 16,
                    cellValue = 1, R = "3"
                },     
                new Matrix_Element{ 
					ElementID = 301,
                    RowID = 18, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 302,
                    RowID = 18, ColID = 18,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 303,
                    RowID = 18, ColID = 19,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 304,
                    RowID = 18, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 305,
                    RowID = 18, ColID = 21,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 306,
                    RowID = 18, ColID = 22,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 307,
                    RowID = 18, ColID = 23,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 308,
                    RowID = 18, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 309,
                    RowID = 18, ColID = 25,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 310,
                    RowID = 18, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 311,
                    RowID = 18, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 312,
                    RowID = 18, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 313,
                    RowID = 19, ColID = 12,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 314,
                    RowID = 19, ColID = 13,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 315,
                    RowID = 19, ColID = 14,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 316,
                    RowID = 19, ColID = 15,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					ElementID = 317,
                    RowID = 19, ColID = 16,
                    cellValue = 0, R = "3"
                },     
                new Matrix_Element{
					ElementID = 318,
                    RowID = 19, ColID = 17,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 319,
                    RowID = 19, ColID = 18,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					ElementID = 320,
                    RowID = 19, ColID = 19,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 321,
                    RowID = 19, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 322,
                    RowID = 19, ColID = 21,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 323,
                    RowID = 19, ColID = 22,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					ElementID = 324,
                    RowID = 19, ColID = 23,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 325,
                    RowID = 19, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 326,
                    RowID = 19, ColID = 25,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 327,
                    RowID = 19, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 328,
                    RowID = 19, ColID = 27,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					ElementID = 329,
                    RowID = 19, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 330,
                    RowID = 20, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 331,
                    RowID = 20, ColID = 13,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 332,
                    RowID = 20, ColID = 14,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 333,
                    RowID = 20, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 334,
                    RowID = 20, ColID = 16,
                    cellValue = 0, R = "3"
                },     
                new Matrix_Element{ 
					ElementID = 335,
                    RowID = 20, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 336,
                    RowID = 20, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 337,
                    RowID = 20, ColID = 19,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 338,
                    RowID = 20, ColID = 20,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					ElementID = 339,
                    RowID = 20, ColID = 21,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 340,
                    RowID = 20, ColID = 22,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 341,
                    RowID = 20, ColID = 23,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 342,
                    RowID = 20, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 343,
                    RowID = 20, ColID = 25,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 344,
                    RowID = 20, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 345,
                    RowID = 20, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 346,
                    RowID = 20, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 347,
                    RowID = 21, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 348,
                    RowID = 21, ColID = 13,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					ElementID = 349,
                    RowID = 21, ColID = 14,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 350,
                    RowID = 21, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 351,
                    RowID = 21, ColID = 16,
                    cellValue = 1, R = "3"
                },     
                new Matrix_Element{ 
					ElementID = 352,
                    RowID = 21, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 353,
                    RowID = 21, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 354,
                    RowID = 21, ColID = 19,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 355,
                    RowID = 21, ColID = 20,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 356,
                    RowID = 21, ColID = 21,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					ElementID = 357,
                    RowID = 21, ColID = 22,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 358,
                    RowID = 21, ColID = 23,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 359,
                    RowID = 21, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 360,
                    RowID = 21, ColID = 25,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 361,
                    RowID = 21, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 362,
                    RowID = 21, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 363,
                    RowID = 21, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 364,
                    RowID = 22, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 365,
                    RowID = 22, ColID = 13,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 366,
                    RowID = 22, ColID = 14,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 367,
                    RowID = 22, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 368,
                    RowID = 22, ColID = 16,
                    cellValue = 1, R = "3"
                },     
                new Matrix_Element{
					ElementID = 369,
                    RowID = 22, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 370,
                    RowID = 22, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 371,
                    RowID = 22, ColID = 19,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 372,
                    RowID = 22, ColID = 20,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 373,
                    RowID = 22, ColID = 21,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 374,
                    RowID = 22, ColID = 22,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 375,
                    RowID = 22, ColID = 23,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 376,
                    RowID = 22, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 377,
                    RowID = 22, ColID = 25,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 378,
                    RowID = 22, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 379,
                    RowID = 22, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 380,
                    RowID = 22, ColID = 28,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 381,
                    RowID = 23, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 382,
                    RowID = 23, ColID = 13,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 383,
                    RowID = 23, ColID = 14,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 384,
                    RowID = 23, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 385,
                    RowID = 23, ColID = 16,
                    cellValue = 1, R = "3"
                },     
                new Matrix_Element{ 
					ElementID = 386,
                    RowID = 23, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 387,
                    RowID = 23, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 388,
                    RowID = 23, ColID = 19,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 389,
                    RowID = 23, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 390,
                    RowID = 23, ColID = 21,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 391,
                    RowID = 23, ColID = 22,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 392,
                    RowID = 23, ColID = 23,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 393,
                    RowID = 23, ColID = 24,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 394,
                    RowID = 23, ColID = 25,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 395,
                    RowID = 23, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 396,
                    RowID = 23, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 397,
                    RowID = 23, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 398,
                    RowID = 24, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 399,
                    RowID = 24, ColID = 13,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 400,
                    RowID = 24, ColID = 14,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 401,
                    RowID = 24, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 402,
                    RowID = 24, ColID = 16,
                    cellValue = 0, R = "3"
                },     
                new Matrix_Element{ 
					ElementID = 403,
                    RowID = 24, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 404,
                    RowID = 24, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 405,
                    RowID = 24, ColID = 19,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 406,
                    RowID = 24, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 407,
                    RowID = 24, ColID = 21,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 408,
                    RowID = 24, ColID = 22,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 409,
                    RowID = 24, ColID = 23,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 410,
                    RowID = 24, ColID = 24,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 411,
                    RowID = 24, ColID = 25,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 412,
                    RowID = 24, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 413,
                    RowID = 24, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 414,
                    RowID = 24, ColID = 28,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 415,
                    RowID = 25, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 416,
                    RowID = 25, ColID = 13,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 417,
                    RowID = 25, ColID = 14,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 418,
                    RowID = 25, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 419,
                    RowID = 25, ColID = 16,
                    cellValue = 1, R = "3"
                },     
                new Matrix_Element{ 
					ElementID = 420,
                    RowID = 25, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 421,
                    RowID = 25, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 422,
                    RowID = 25, ColID = 19,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 423,
                    RowID = 25, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 424,
                    RowID = 25, ColID = 21,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 425,
                    RowID = 25, ColID = 22,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 426,
                    RowID = 25, ColID = 23,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 427,
                    RowID = 25, ColID = 24,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 428,
                    RowID = 25, ColID = 25,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 429,
                    RowID = 25, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 430,
                    RowID = 25, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 431,
                    RowID = 25, ColID = 28,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 432,
                    RowID = 26, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 433,
                    RowID = 26, ColID = 13,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 434,
                    RowID = 26, ColID = 14,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 435,
                    RowID = 26, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 436,
                    RowID = 26, ColID = 16,
                    cellValue = 1, R = "3"
                },     
                new Matrix_Element{ 
					ElementID = 437,
                    RowID = 26, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 438,
                    RowID = 26, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 439,
                    RowID = 26, ColID = 19,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 440,
                    RowID = 26, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 441,
                    RowID = 26, ColID = 21,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 442,
                    RowID = 26, ColID = 22,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 443,
                    RowID = 26, ColID = 23,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 444,
                    RowID = 26, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 445,
                    RowID = 26, ColID = 25,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 446,
                    RowID = 26, ColID = 26,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 447,
                    RowID = 26, ColID = 27,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 448,
                    RowID = 26, ColID = 28,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 449,
                    RowID = 27, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 450,
                    RowID = 27, ColID = 13,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 451,
                    RowID = 27, ColID = 14,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 452,
                    RowID = 27, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 453,
                    RowID = 27, ColID = 16,
                    cellValue = 1, R = "3"
                },     
                new Matrix_Element{ 
					ElementID = 454,
                    RowID = 27, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 455,
                    RowID = 27, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 456,
                    RowID = 27, ColID = 19,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 457,
                    RowID = 27, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 458,
                    RowID = 27, ColID = 21,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 459,
                    RowID = 27, ColID = 22,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 460,
                    RowID = 27, ColID = 23,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 461,
                    RowID = 27, ColID = 24,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 462,
                    RowID = 27, ColID = 25,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 463,
                    RowID = 27, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 464,
                    RowID = 27, ColID = 27,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{
					ElementID = 465,
                    RowID = 27, ColID = 28,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 466,
                    RowID = 28, ColID = 12,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 467,
                    RowID = 28, ColID = 13,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 468,
                    RowID = 28, ColID = 14,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 469,
                    RowID = 28, ColID = 15,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 470,
                    RowID = 28, ColID = 16,
                    cellValue = 1, R = "3"
                },     
                new Matrix_Element{
					ElementID = 471,
                    RowID = 28, ColID = 17,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{
					ElementID = 472,
                    RowID = 28, ColID = 18,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 473,
                    RowID = 28, ColID = 19,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 474,
                    RowID = 28, ColID = 20,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 475,
                    RowID = 28, ColID = 21,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 476,
                    RowID = 28, ColID = 22,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 477,
                    RowID = 28, ColID = 23,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 478,
                    RowID = 28, ColID = 24,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 479,
                    RowID = 28, ColID = 25,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 480,
                    RowID = 28, ColID = 26,
                    cellValue = 1, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 481,
                    RowID = 28, ColID = 27,
                    cellValue = 0, R = "3"
                },
                new Matrix_Element{ 
					ElementID = 482,
                    RowID = 28, ColID = 28,
                    cellValue = 0, R = "3"
                },
//================= Matrix R34 ==============//
                new Matrix_Element{ 
					ElementID = 483,
                    RowID = 12, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 484,
                    RowID = 12, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 485,
                    RowID = 12, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 486,
                    RowID = 12, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 487,
                    RowID = 12, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 488,
                    RowID = 12, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 489,
                    RowID = 12, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 490,
                    RowID = 12, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 491,
                    RowID = 12, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 492,
                    RowID = 12, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 493,
                    RowID = 13, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 494,
                    RowID = 13, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 495,
                    RowID = 13, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					ElementID = 496,
                    RowID = 13, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 497,
                    RowID = 13, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 498,
                    RowID = 14, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 499,
                    RowID = 14, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 500,
                    RowID = 14, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 501,
                    RowID = 14, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 502,
                    RowID = 14, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 503,
                    RowID = 15, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 504,
                    RowID = 15, ColID = 30,
                    cellValue = 0, R = "34"
                },
                new Matrix_Element{
					ElementID = 505,
                    RowID = 15, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 506,
                    RowID = 15, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 507,
                    RowID = 15, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 508,
                    RowID = 16, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 509,
                    RowID = 16, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 510,
                    RowID = 16, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					ElementID = 511,
                    RowID = 16, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 512,
                    RowID = 16, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 513,
                    RowID = 17, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 514,
                    RowID = 17, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 515,
                    RowID = 17, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 516,
                    RowID = 17, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 517,
                    RowID = 17, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 518,
                    RowID = 18, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 519,
                    RowID = 18, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 520,
                    RowID = 18, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 521,
                    RowID = 18, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 522,
                    RowID = 18, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					ElementID = 523,
                    RowID = 19, ColID = 29,
                    cellValue = 0, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 524,
                    RowID = 19, ColID = 30,
                    cellValue = 0, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 525,
                    RowID = 19, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 526,
                    RowID = 19, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					ElementID = 527,
                    RowID = 19, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					ElementID = 528,
                    RowID = 20, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 529,
                    RowID = 20, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 530,
                    RowID = 20, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 531,
                    RowID = 20, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 532,
                    RowID = 20, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					ElementID = 533,
                    RowID = 21, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					ElementID = 534,
                    RowID = 21, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 535,
                    RowID = 21, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					ElementID = 536,
                    RowID = 21, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					ElementID = 537,
                    RowID = 21, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 538,
                    RowID = 22, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 539,
                    RowID = 22, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 540,
                    RowID = 22, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 541,
                    RowID = 22, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					ElementID = 542,
                    RowID = 22, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 543,
                    RowID = 23, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 544,
                    RowID = 23, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 545,
                    RowID = 23, ColID = 31,
                    cellValue = 0, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 546,
                    RowID = 23, ColID = 32,
                    cellValue = 0, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 547,
                    RowID = 23, ColID = 33,
                    cellValue = 0, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 548,
                    RowID = 24, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 549,
                    RowID = 24, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 550,
                    RowID = 24, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 551,
                    RowID = 24, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					ElementID = 552,
                    RowID = 24, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 553,
                    RowID = 25, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 554,
                    RowID = 25, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 555,
                    RowID = 25, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 556,
                    RowID = 25, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 557,
                    RowID = 25, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 558,
                    RowID = 26, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 559,
                    RowID = 26, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{
					ElementID = 560,
                    RowID = 26, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 561,
                    RowID = 26, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 562,
                    RowID = 26, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 563,
                    RowID = 27, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 564,
                    RowID = 27, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 565,
                    RowID = 27, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 566,
                    RowID = 27, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 567,
                    RowID = 27, ColID = 33,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 568,
                    RowID = 28, ColID = 29,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 569,
                    RowID = 28, ColID = 30,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 570,
                    RowID = 28, ColID = 31,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 571,
                    RowID = 28, ColID = 32,
                    cellValue = 1, R = "34"
                },
                new Matrix_Element{ 
					ElementID = 572,
                    RowID = 28, ColID = 33,
                    cellValue = 1, R = "34"
                },
            };
            return entries;
        }
    }
}
