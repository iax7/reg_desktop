# reg_desktop
This is a complementary project, this is app uses the [reg](https://github.com/iax7/reg) 
project API to work.
As a desktop app you can connect a barcode reader to read the badges codes that 
reg project generates. Is intended to be used to mark the person arrival to the event, 
and count real food consumption, to avoid over consumption.

## Instalation

* Clone the project 
* Open the project in [Visual Studio](https://www.visualstudio.com/)
* Run it

## Configuration

* You need to have a running instance of [reg](https://github.com/iax7/reg) Rails project app.
* In the app's home look for `Registration.exe.config` file to edit values before running.
	url = https://{yourapp.herokuapp.com}/api/v1/
	api_user = The username you used in your Rails configuration file
	api_pass = The password you used in your Rails configuration file
* If everything is set you can test the connection with the ping option.
	[Ping](github/ping.png)

## To Do

* The UI is in spanish, and is not configured to be multilanguage.
* The UI is in WinForms, should be migrated to XAML.


## Contribute

You are welcome to contribute in this project, I found these [Instructions](https://gist.github.com/MarcDiethelm/7303312) 
very helpful.

## Licensing

This app is licensed under the Apache License, Version 2.0. See LICENSE for full license text.