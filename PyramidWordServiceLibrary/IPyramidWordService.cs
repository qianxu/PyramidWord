using System.ServiceModel;

namespace PyramidWordServiceLibrary
{
    [ServiceContract]
    public interface IPyramidWordService
    {
        /// <summary>
        /// Check whether the inputted word is pyramid word.
        /// </summary>
        /// <param name="word">The inputted word.</param>
        /// <returns>
        /// True: it is pyramid word.
        /// False: it is not pyramid word.
        /// </returns>
        [OperationContract]
        bool IsPyramidWord(string word);
    }
}
