using System.Collections.Generic;
using System.Data.Entity;


namespace Trojan.Models
{
    public class MatrixDatabaseInitializer : DropCreateDatabaseAlways<MatrixContext>
    {

        protected override void Seed(MatrixContext context)
        {
            GetR1().ForEach(c => context.Matrix_Element.Add(c));
        }

        private static List<Matrix_Element> GetR1()
        {
            var entries = new List<Matrix_Element>
            {
                new Matrix_Element{
                    RowNo = 1, ColNo = 1,
                    cellValue = 0
                },
                new Matrix_Element{
                    RowNo = 1, ColNo = 2,
                    cellValue = 1
                },
                new Matrix_Element{
                    RowNo = 1, ColNo = 3,
                    cellValue = 0
                },
                new Matrix_Element{
                    RowNo = 1, ColNo = 4,
                    cellValue = 0
                },
                new Matrix_Element{
                    RowNo = 1, ColNo = 5,
                    cellValue = 0
                },
                new Matrix_Element{
                    RowNo = 2, ColNo = 1,
                    cellValue = 0
                },
                new Matrix_Element{
                    RowNo = 2, ColNo = 2,
                    cellValue = 0
                },
                new Matrix_Element{
                    RowNo = 2, ColNo = 3,
                    cellValue = 1
                },
                new Matrix_Element{
                    RowNo = 2, ColNo = 4,
                    cellValue = 0
                },
                new Matrix_Element{
                    RowNo = 2, ColNo = 5,
                    cellValue = 0
                },
                new Matrix_Element{
                    RowNo = 3, ColNo = 1,
                    cellValue = 0
                },
                new Matrix_Element{
                    RowNo = 3, ColNo = 2,
                    cellValue = 0
                },
                new Matrix_Element{
                    RowNo = 3, ColNo = 3,
                    cellValue = 0
                },
                new Matrix_Element{
                    RowNo = 3, ColNo = 4,
                    cellValue = 1
                },
                new Matrix_Element{
                    RowNo = 3, ColNo = 5,
                    cellValue = 0
                },
                new Matrix_Element{
                    RowNo = 4, ColNo = 1,
                    cellValue = 0
                },
                new Matrix_Element{
                    RowNo = 4, ColNo = 2,
                    cellValue = 0
                },
                new Matrix_Element{
                    RowNo = 4, ColNo = 3,
                    cellValue = 0
                },
                new Matrix_Element{
                    RowNo = 4, ColNo = 4,
                    cellValue = 0
                },
                new Matrix_Element{
                    RowNo = 4, ColNo = 5,
                    cellValue = 1
                },
                new Matrix_Element{
                    RowNo = 5, ColNo = 1,
                    cellValue = 0
                },
                new Matrix_Element{
                    RowNo = 5, ColNo = 2,
                    cellValue = 0
                },
                new Matrix_Element{
                    RowNo = 5, ColNo = 3,
                    cellValue = 0
                },
                new Matrix_Element{
                    RowNo = 5, ColNo = 4,
                    cellValue = 0
                },
                new Matrix_Element{
                    RowNo = 5, ColNo = 5,
                    cellValue = 0
                },                
            };
            return entries;
        }
    }
}