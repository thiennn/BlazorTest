namespace BlazorDemo.Client.Helpers
{
    public static class StringHelper
    {
        public static string ToUpper(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            return text.ToUpper();
        }
    }
}
