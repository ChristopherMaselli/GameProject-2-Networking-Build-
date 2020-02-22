# GameProject-2-Networking-Build-Files
GameProject#2 information is generally private, however I've decided to post all of my Networking (GameServer and API) code here for view, along with instructions for reproducing.

Usage:

Code located in "Server" folder details the code for the .Net-run server to be connected too. running "Program" code will result in server being run and attempting to listen for clients of matching IP address and Port. 

Code located in "Unity" folder displays code to be used in-scene to connect Unity game-scenes to server. for use attach "Client" code to an Empty Game Object (preferably named "ClientManager") and connect UI manager to UI canvas with button with On-Click function "ConnectToServer" activating when button is clicked. 

Update: Folder "UnityServer" Contains the code needed to run a server version on Unity. Folder is temporary and I will be expanding the project into a fully-functional blank unity project with 
Networking capabilities, including both a server and client version. After I finish that, I plan to upload a fully functional API to run it with. 
