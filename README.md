# PoP - Assignment 9
PoP - 9g

Don't be stupid...

# PoP - 9g


## Kode


Biblioteket readNWrite compiles med fsharpc:

	$ fsharpc -a readNWrite.fs



cat.fsx, tac.fsx og countLinks.fsx compiles med fsharpc og køres med mono:

	$ fsharpc -r readNWrite.dll cat.fsx
	$ mono cat.exe <args>
	$ fsharpc -r readNWrite.dll tac.fsx
	$ mono tac.exe <args>
	$ fsharpc countLinks.fsx
	$ mono countLinks.exe <arg>



Eksempler på kørsel af programmer;
	cat:
	$ mono cat.exe a.txt
	$ mono cat.exe a.txt b.txt
	$ mono cat.exe a.txt b.txt c.txt
	
	tac:
	$ mono tac.exe a.txt
	$ mono tac.exe a.txt b.txt
	$ mono tac.exe a.txt b.txt c.txt
	
	countLinks (OBS: HTTPS hjemmesider er IKKE understøttede.):
	$ mono countLinks.exe http://info.cern.ch/
	$ mono countLinks.exe http://fsprojects.github.io/
