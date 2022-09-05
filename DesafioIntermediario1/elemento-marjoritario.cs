using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(String[] args)
    {
        //Console.WriteLine("Digite a quantidade de números: ");
        int n = int.Parse(Console.ReadLine());
        
        int[] num = new int[n];

        for (int i = 0; i < num.Length; i++)
        {
            //Console.WriteLine("Digite o número: ");
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(MajorityElement(num));
        
    }
    public static int MajorityElement(int[] nums)
    {
        int major = nums[0];
        int count = 0;
        int auxcount = 0;
        for (int i = 0; i < nums.Length; i++)
        {
           for (int j = 0; j < nums.Length; j++){
                if(nums[i] != major){
                    if(nums[i] == nums[j])
                        count++;
                }
            }

            if (count > auxcount)
            {
                major = nums[i];
                auxcount = count;
                count = 0;
            }

        }
        return major;
    }
}