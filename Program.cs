#region
//int a = 24;
//int count = 0;

//{
//    int target = a;

//    int high = 2;

//    while (high < target)
//    {
//        high *= 2;
//        count++;
//    }

//    int low = high / 2;

//    int p_high = high - target;
//    int p_low = target - low;

//    if (p_high <= p_low)
//    {

//        {

//        }
//        Console.WriteLine(count + 1);

//    }
//    else
//    {
//        Console.WriteLine(count);
//    }
//}
#endregion

#region
//int num = 2568,
//    sum = 0;

//while (num>0)
//{
//    sum += num % 10;
//    num = (num / 10);
//}

//Console.WriteLine(sum);
#endregion

#region
int num = 17;
if (num == 0 || num == 1)
{
    Console.WriteLine(num + " ne sade ne de murekkeb ededdir");
}
else
{
    for (int a = 2; a <= num / 2; a++)
    {
        if (num % a == 0)
        {
            Console.WriteLine  (num + " murekkeb ededdir");

        }

    }
    Console.WriteLine(num + " sade ededdir");
}

#endregion