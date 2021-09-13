namespace Tests
{
    public interface IEnumParseTests
    {
        void ParseString();
        void ParseStringIgnoreCaseFails();
        void ParseInvalidStringFails();
        void ParseNumber();
        void ParseInvalidNumberFails();
    }
}