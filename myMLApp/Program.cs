using System;
using MyMLAppML.Model;

namespace myMLApp
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("+++++++++++++++++++++++++++++++++++ Sentiment Analysis using ML.NET +++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++++ Prediction is based reviews left by uses on wikipedia +++++++++++++++++++++++++++");
            Console.WriteLine("+++++++++ Datasource used for tranining: https://raw.githubusercontent.com/dotnet/machinelearning/master/test/data/wikipedia-detox-250-line-data.tsv");
            
            while (true)
            {
                Console.WriteLine("\nType a review and press Enter for prediction to begin!");
                string userReview = Console.ReadLine();
                ModelInput input = new ModelInput { SentimentText = userReview };
                Console.WriteLine($"Predicting sentiment for the review '{input.SentimentText}'...");

                // Predict sentiment using pre-trained model
                ModelOutput result = ConsumeModel.Predict(input);
                Console.WriteLine($"Predicted sentiment: {result.Prediction}");
            }
        }
    }
}