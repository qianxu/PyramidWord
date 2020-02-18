# PyramidWord
Create a WCF service to check whether a word is pyramid word.

A word is a ‘pyramid’ word if you can arrange the letters in increasing frequency, starting with 1 and continuing without gaps and without duplicactes. The word can only contains letters and is case sensitive.

Examples:

    banana is a pyramid word because you have 1 'b', 2 'n's, and 3 'a's.
    bandana is not a pyramid word because you have 1 'b' and 1 'd'.
    baNana is not a pyramid word because you have 1 'b', 1 'N' and 1 'n'.

How to test it:
1. Build and start PyramidWordServiceLibrary service.
2. Build and start WCFClient console application. Input any word to check whether it is pyramid word. Input nothing to exit.

Note: 
If it fails to connect to the PyramidWord service, please delete the service and add it again in WCFClient solution.
