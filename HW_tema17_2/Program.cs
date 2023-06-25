Console.Write("Введите размерность массивов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,]arr_1 = new int[3,cols];


Random rand = new Random();

for(int i=0; i<3; i++) //цикл заполнения
{
    for(int j=0; j<cols; j++)
    {
        arr_1[i, j] = rand.Next(1, 11);

        Console.Write(arr_1[i, j]+"\t");
    }
    Console.WriteLine();
}

int summ_rows = 0;
int summ = 0;
int count = 0;


for (int i = 0; i < 3; i++) //цикл подсчета суммы
{
    for (int j = 0; j < cols; j++)
    {
        summ_rows+=arr_1[i,j];
        count++;
        summ += summ_rows;
    }
    Console.WriteLine($"Сумма {i} строки = {summ_rows}");
}

int summa_average = summ / count;
Console.WriteLine($"общая сумма {summ}, среднее значение {summa_average}");
