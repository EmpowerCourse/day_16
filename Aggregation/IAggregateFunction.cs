using System;

namespace Aggregation
{
    public interface IAggregateFunction
    {
        void Insert(int value);
        int Calculate();
    }
}
