// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.TestUtilities;
using Xunit.Abstractions;

namespace Microsoft.EntityFrameworkCore.Query
{
    public class AsyncIncludeSqlServerTest : IncludeAsyncTestBase<IncludeSqlServerFixture>
    {
        public AsyncIncludeSqlServerTest(IncludeSqlServerFixture fixture, ITestOutputHelper testOutputHelper)
            : base(fixture)
        {
            //fixture.TestSqlLoggerFactory.SetTestOutputHelper(testOutputHelper);
        }

        [SqlServerCondition(SqlServerCondition.SupportsOffset)] // Test does not pass on SqlServer 2008. TODO: See issue#7160
        public override Task Include_duplicate_reference()
        {
            return base.Include_duplicate_reference();
        }

        public override Task Include_multiple_references_then_include_collection_multi_level_reverse()
        {
            return base.Include_multiple_references_then_include_collection_multi_level_reverse();
        }
    }
}
