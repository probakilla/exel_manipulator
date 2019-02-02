using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;

namespace ExelManipulator.Src.ExelParsing {
    public class XlsReader {
        private string fileName;

        public XlsReader(string fileName) {
            this.fileName = fileName;
        }

        public string getName() {
            return this.fileName;
        }
    }
}