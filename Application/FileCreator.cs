using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class FileCreator : IDisposable
    {

        private FileStream _fileStream;
        private BinaryReader _binaryReader;
        private BinaryWriter _binaryWriter;
        public FileCreator(string path, TeachersCharacteristics teacher)
        {
            _fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            _binaryReader = new BinaryReader(_fileStream);
            _binaryWriter = new BinaryWriter(_fileStream);

            //if (_fileStream.Length != 0)
            //{

            //}
            //else
            //{

            //}
        }

        public void WriteInfo(TeachersCharacteristics teacher)
        {
            _writeString(teacher.FullName);// ?


            _binaryWriter.Write(teacher.Grade.FindAll((x) => x == 5.0).Count);//4
            _binaryWriter.Write(teacher.Grade.FindAll((x) => x == 4.0).Count);//4
            _binaryWriter.Write(teacher.Grade.FindAll((x) => x == 3.0).Count);//4
            _binaryWriter.Write(teacher.Grade.FindAll((x) => x == 2.0).Count);//4
            _binaryWriter.Write(teacher.Grade.FindAll((x) => x == 1.0).Count);//4

            _fileStream.Position = 0;
        }

        public TeachersCharacteristics ReadInfo()
        {
            int fullnameLength = _binaryReader.ReadInt32();
            byte[] bytes = new byte[fullnameLength];

            _fileStream.Read(bytes, 0, bytes.Length);
            string fullName = Encoding.Unicode.GetString(bytes);
            int aGrade = _binaryReader.ReadInt32();
            int bGrade = _binaryReader.ReadInt32();
            int cGrade = _binaryReader.ReadInt32();
            int dGrade = _binaryReader.ReadInt32();
            int fGrade = _binaryReader.ReadInt32();


            TeachersCharacteristics t = new TeachersCharacteristics(fullName, 42, null);
            t.Grade.AddRange(_addGrades(5, aGrade));
            t.Grade.AddRange(_addGrades(4, bGrade));
            t.Grade.AddRange(_addGrades(3, cGrade));
            t.Grade.AddRange(_addGrades(2, dGrade));
            t.Grade.AddRange(_addGrades(1, fGrade));
            return t;
        }



        private void _writeString(string text)
        {
            int textLength = Encoding.Unicode.GetByteCount(text);

            byte[] byteArr = Encoding.Unicode.GetBytes(text);

            _binaryWriter.Write(textLength);
            _fileStream.Write(byteArr, 0, byteArr.Length);
        }

        public void Dispose()
        {
            _fileStream.Close();
        }
        private List<double> _addGrades(int grade, int count)
        {
            List<double> list = new List<double>();
            for (int i = 0; i < count; i++)
            {
                list.Add(grade);
            }
            return list;
        }
    }
}
