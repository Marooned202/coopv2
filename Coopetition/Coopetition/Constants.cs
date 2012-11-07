using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coopetition
{
    public static class Constants
    {
        public enum Strategy
        {
            Competition = 1,
            Cooperation,
            Coopetition
        }

        public enum WebserviceType
        { 
            Coopetitive = 1,
            JustCompetitive,
            Random
        }

        public enum SimulationType
        {
            Coopetitive = 1,
            AllCompetitive,
            AllRandom
        }

        public const string BaseDirectory = @"C:\Projects\Thesis\Coopetition\Results\";
        public static int NumberOfWebservices = 50;
        public static int NumberOfCommunities = 5;
        public static int NumberOfUsers = 1000;
        public static int NumberOfTasks = 2500;
        public static int NumberOfRuns = 50; // 50
        public static int MaxNumberOfTasksPerRun = 32;
        public static int MinNumberOfTasksPerRun = 30;

        public static double CoopetitiveWebservicesPercentage = 0.6;

        public static double CompetitionThreshold = 0.46;
        public static int MembershipFee = 3; // was 1
        public static double reputationDecay = 0.008;
        public static double CooperationFeePercentage = 0.2;
        public static double CompetitionProbability = 0.5;

        public static double WebserviceQoS_LowerBound = 0.01;
        public static double WebserviceQoS_UpperBound = 0.99;

        public static double WebserviceReputation_LowerBound = 0.01;
        public static double WebserviceReputation_UpperBound = 0.99;

        public static double WebserviceGrowthFactor_LowerBound = 0.01;
        public static double WebserviceGrowthFactor_UpperBound = 0.99;

        public static double InitialWebserviceReputation_LowerBound = 0.49;
        public static double InitialWebserviceReputation_UpperBound = 0.7;

        //public static double InitialWebserviceGrowthFactor_LowerBound = 0.01;
        //public static double InitialWebserviceGrowthFactor_UpperBound = 0.99;

        //public static int WebserviceBudget_LowerBound = 100;
        //public static int WebserviceBudget_UpperBound = 200;
        public static int WebserviceDefaultBudget = 150;

        public static double TaskQoS_LowerBound = 0.6; // was 0.5
        public static double TaskQoS_UpperBound = 0.99; // was 0.9

        public static double TaskResponseTime_LowerBound = 0.1;
        public static double TaskResponseTime_UpperBound = 0.5;

        public static int TaskFee_LowerBound = 12;
        public static int TaskFee_UpperBound = 22;

        // Will use theoretical results
        public static double DoingAloneProbability = 0.2;
        public static double CollaborateProbability = 0.8;
        //

        public static double AcceptanceProbability = 1; // Probability of accepting an offered task

        public static double MainTaskPortion = 0.5;

        public static double ResponsibleWSPunishmentPercentage = 0.8;

        public static double ResponsibleWSQoSPortion = 0.8;
        public static double QoSVarianceModifier = 10;

        public static double RewardCoefficient = 0.001;
        public static double RewardConstant = 0.02;

        public static double PenaltyCoefficient = 0.01;
        public static double PenaltyConstant = 0.04; // 0.05

        public static int CollaborationNetworkSize_LowerBound = 2;
        public static int CollaborationNetworkSize_UpperBound = 5;

        public static int NumberOfNetworksInCommunity = 12;

        public static double ReputationThreshold = 0.45; //0.5
        
    }
}
