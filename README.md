# PoP - Assignment 9
PoP - 9g

This assignment was about reading and writing to/from files. In this case, we were tasked with concatting, reversing, and countring the amount of hyperlinks in a file.

# PoP - 9g


## Kode


The library is compiled with fsharpc;

	$ fsharpc -a readNWrite.fs



cat.fsx, tac.fsx og countLinks.fsx compiles med fsharpc og køres med mono:

	$ fsharpc -r readNWrite.dll cat.fsx
	$ mono cat.exe <args>
	$ fsharpc -r readNWrite.dll tac.fsx
	$ mono tac.exe <args>
	$ fsharpc countLinks.fsx
	$ mono countLinks.exe <arg>



Examples of running the programs;
	
	cat:
	$ mono cat.exe a.txt
	$ mono cat.exe a.txt b.txt
	$ mono cat.exe a.txt b.txt c.txt
	
	tac:
	$ mono tac.exe a.txt
	$ mono tac.exe a.txt b.txt
	$ mono tac.exe a.txt b.txt c.txt
	
	countLinks (NOTE: HTTPS websites are NOT supported):
	$ mono countLinks.exe http://info.cern.ch/
	$ mono countLinks.exe http://fsprojects.github.io/
