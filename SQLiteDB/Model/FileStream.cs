using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDB.Model
{
    public class FileStream
    {
        private int id;
        private string name;
        private string path;
        private int flgcopy;
        private int dimension;
        private string extension;

        public int Flgcopy { get => flgcopy; set => flgcopy = value; }
        public string Path { get => path; set => path = value; }
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public int Dimension { get => dimension; set => dimension = value; }
        public string Extension { get => extension; set => extension = value; }
    }
}
