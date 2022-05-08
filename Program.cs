SampleNamespace.SampleClass sample = new();
sample.SampleMethod();

namespace SampleNamespace
{
    class SampleClass
    {
        public void SampleMethod()
        {
            Console.WriteLine("SampleMethod inside SampleNamespace");
        }
    }
}