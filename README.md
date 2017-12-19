# Fools_Flash
This application check the existence of flash drive every 20sec, if a new flash drive exists, it copies its contents to the documents folder, the folder is named after the flash name with under dash and the number of free clusters.
It doesn’t re-copy the flash contents as long as the number of free clusters is the same, in case of a change in the number of free clusters is re-copy the new flash contents.
The application automatically puts itself in startup, to change that just uncheck the auto run item in the context menu, there is also a simple setting interface.
I have added some copy exceptions to protect you from common viruses, it works but don’t expect it to fully protect your pc
By renaming the application file to “fools2flash.exe”, the application changes its behavior to copy docx and jpg files from desktop, documents, my pictures and my music to a folder he creates called “secret” in the same path of the application and add the hidden and system attributes to it
When running the application in this mode it automatically creates setting files in which you can add the path you prefer the application to search in and any other extensions you are interested in. after finishing this the application exit itself
