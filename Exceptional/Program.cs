namespace exceptional;
class Program
{
    static void Main(string[] args)
    {
        Exception[] exces = {
            new DataMisalignedException("DataMisalignedException"),
            new BarrierPostPhaseException("BarrierPostPhaseException"),
            new LockRecursionException("LockRecursionException"),
            new TimeZoneNotFoundException("LockRecursionException"),
            new ExceptionalException("ExceptionalException") };
        foreach (Exception ex in exces)
        {
            try { throw ex; }
            catch (Exception ee) { Console.WriteLine(ee.Message); }
            finally { Console.Write(string.Empty + Environment.NewLine); }
        }
        Console.ReadKey();
    }

    public class ExceptionalException : Exception
    {
        public ExceptionalException() { }
        public ExceptionalException(string message) : base(message + " (this one is very much like others, but it's mine)") { }
        public ExceptionalException(string message,  Exception innerException)
            : base(message + " (this one is very much like others, but it's mine)", innerException) { }
    }
}