//string[] array={"1234","1567","-2","computer science"};
string[] array={"hello","2","world",":-)"};
//string[] array={"Russia","Denmark","Kazan"};

string[] resultArr=new string[0];

for(int i=0;i<array.Length;i++)
{
if(array[i].Length<=3)
{
Array.Resize(ref resultArr,resultArr.Length+1);
resultArr[resultArr.Length-1]=array[i];
}
}

Console.WriteLine("[{0}]",String.Join(",",resultArr));
