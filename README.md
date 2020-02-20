# PyramidWord
Create WCF service to check whether a word is pyramid word.

A word is a ‘pyramid’ word if you can arrange the letters in increasing frequency, starting with 1 and continuing without gaps and without duplicactes. The word can only contains letters and is case sensitive.

Examples:

    banana is a pyramid word because you have 1 'b', 2 'n's, and 3 'a's.
    bandana is not a pyramid word because you have 1 'b' and 1 'd'.
    baNana is not a pyramid word because you have 1 'b', 1 'N' and 1 'n'.

How to test it:
1. Open solutions PyramidWordService and WCFClient in Visual Studio 2017 or newer version.
2. Build and start PyramidWordService service.
3. Build and start WCFClient console application to send HTTP request or you can type url directly in WebBrowser (e.g. http://localhost:38955/PyramidWordService.svc/ispyramidword?word=aaabbc)

Note: 
You can also test PyramidWord using solution "PyramidWordServiceLibrary" which supports SOAP only. If it fails to connect to the PyramidWordServiceLibrary service, please delete the service and add it again in WCFClient solution. You need to copy the service address from WCF Test Client and add it in the dialog of "Add Service Reference".
