namespace Behavioral.ChainOfResponsibility.BrokerChain
{
    public class Query
    {
        public string CreatureName;
        
        public enum Argument
        {
            Attack, Defense
        }

        public Argument WhatToQuery;
        public int Value;

        public Query(string creatureName, Argument whatToQuery, int value)
        {
            CreatureName = creatureName;
            WhatToQuery = whatToQuery;
            Value = value;
        }
    }
}