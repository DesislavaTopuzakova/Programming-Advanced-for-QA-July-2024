using System.Diagnostics;
using System.Text;
//StringBuilder е много по-бърз от string

//конкатенация със string (+)
Stopwatch sw = new Stopwatch();
sw.Start();
string text = "";
for (int i = 0; i < 200000; i++)
{
    text += i; //text = text + i;
}
sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds); // 20116



//конкатенация със StringBuilder (Append)
/*Stopwatch sw = new Stopwatch();
sw.Start();
StringBuilder text = new StringBuilder();
for (int i = 0; i < 200000; i++)
{
    text.Append(i);
}
sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds); // 2
*/


//Кога да използваме StringBuilder?
//1. когато имаме много пъти повтаряща се конкатенация
//2. когато искаме да модифицираме по-сериозно даден текст
//3. StringBuilder-a е по-бърз и има повече възможности (вградени методи)
//за модификация и обработка на текст




