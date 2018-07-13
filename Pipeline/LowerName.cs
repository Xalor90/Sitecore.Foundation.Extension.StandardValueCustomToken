using Sitecore.Diagnostics;
using Sitecore.Pipelines.ExpandInitialFieldValue;

namespace Sitecore.Foundation.Extension.StandardValueCustomToken.Pipeline
{
    public class LowerName : ExpandInitialFieldValueProcessor
    {
        private const string Token = "$lowerName";

        public override void Process(ExpandInitialFieldValueArgs args)
        {
            Assert.ArgumentNotNull(args, "args");
            args.Result = args.Result.Replace(Token, args.TargetItem.Name.ToLower().Replace(" ", "-"));
        }
    }
}