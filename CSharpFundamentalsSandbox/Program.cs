using static CSharpFundamentalsSandbox.Katas.OOP.Classes;

namespace CSharpFundamentalsSandbox
{
    internal class Program
    {
        // private static void Helper(Action action)
        // {
        //     try
        //     {
        //         action();
        //     }
        //     catch (Exception e)
        //     {
        //         Console.WriteLine(e);
        //     }
        // }

        public static void Main(string[] args)
        {
            var post = new Post("Test Title", "Test Description");
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();

            post.PostDetails();
        }
    }
}