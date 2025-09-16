using System;

namespace CSharpFundamentalsSandbox.Katas.OOP
{
    public class Classes
    {
        // EXERCISE 1
        // Design a class called Stopwatch. The job of this class is to simulate a stopwatch.
        // It should provide two methods:
        // Start and Stop. We call the start method first, and the stop method next.
        // Then we ask the stopwatch about the duration between start and stop.
        // Duration should be a value in TimeSpan. Display the duration on the console. We should also be able to use a stopwatch multiple times.
        // So we may start and stop it and then start and stop it again. Make sure the duration value each time is calculated properly.
        // We should not be able to start a stopwatch twice in a row (because that may overwrite the initial start time). So the class should throw an InvalidOperationException if its started twice.

        public class Stopwatch
        {
            private DateTime _startTime;
            private bool _timerStarted;

            public void StartTimer()
            {
                if (!_timerStarted)
                {
                    _timerStarted = true;
                    _startTime = DateTime.Now;
                    Console.WriteLine("Timer Started");
                }
                else
                {
                    throw new InvalidOperationException("StartTimer is already running");
                }
            }

            public void StopTimer()
            {
                if (_timerStarted)
                {
                    _timerStarted = false;
                    Console.WriteLine("Timer was running for {0}", DateTime.Now - _startTime);
                }
                else
                {
                    throw new InvalidOperationException("StartTimer must be called first");
                }
            }
        }

        // Design a class called Post. This class models a StackOverflow post.
        // It should have properties for title, description and the date/time it was created.
        // We should be able to up-vote or down-vote a post.
        // We should also be able to see the current vote value.
        // In the main method, create a post, up-vote and down-vote it a few times and then display the current vote value.
        // In this exercise, you will learn that a StackOverflow post should provide methods for up-voting and down-voting.
        // You should not give the ability to set the Vote property from the outside, because otherwise, you may accidentally change the votes of a class to 0 or to a random number.
        // And this is how we create bugs in our programs. The class should always protect its state and hide its implementation detail

        public class Post
        {
            public Post(string title, string description)
            {
                Title = title;
                Description = description;
                CreatedAt = DateTime.Now;
            }

            public int NumberOfVotes { get; private set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime CreatedAt { get; set; }

            public void UpVote()
            {
                NumberOfVotes += 1;
            }

            public void DownVote()
            {
                NumberOfVotes -= 1;
            }

            public void PostDetails()
            {
                Console.WriteLine("Title: {0}", Title);
                Console.WriteLine("Description: {0}", Description);
                Console.WriteLine("Date Posted: {0}", CreatedAt);
                Console.WriteLine("Number of votes: {0}", NumberOfVotes);
            }
        }
    }
}