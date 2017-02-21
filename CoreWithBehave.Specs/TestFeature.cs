using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xbehave;

using Xunit;

namespace CoreWithBehave.Specs
{
    public class TestFeature
    {
        [Scenario]
        public void ScenarioName(int one, int two, int res)
        {
            "Given AAA"
                .x(() =>
                {
                    one = 1;
                    two = 2;
                });

            "When BBB"
                .x(() => res = one + two);

            "Then CCC"
                .x(() => Assert.Equal(res, 3));
        }
    }
}
