using Application.EventHandlers;
using Application;

Directory.SetCurrentDirectory("Teachers");

TeachersCharacteristics teachersCharacteristics = new TeachersCharacteristics("Озерова", 10, GetAlernt);
for (int i = 0; i < 26; i++)
{
    teachersCharacteristics.CalculateGradeWithTime(5);//Random.Shared.Next(1, 6));
}

using (FileCreator fc = new FileCreator($"{teachersCharacteristics.FullName}.txt", teachersCharacteristics))
{
    fc.WriteInfo(teachersCharacteristics);
    TeachersCharacteristics teachersCharacteristicsfc = fc.ReadInfo();

    List<double >list = teachersCharacteristicsfc.Grade;
    list.Sort();
    int doubles = list.FindAll(x=> x == 5.0).Count;
    Console.WriteLine();
}
Console.ReadLine();

static void GetAlernt(object sender, EventArgs e)
{
    GradeEventHandler handler = (GradeEventHandler)e;
    Console.WriteLine(handler.Message);
}