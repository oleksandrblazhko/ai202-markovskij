### Опис тестових сценарії

| FR ID 	| TC ID 	|                                                                                                  Опис кроків тестового сценарію 	| Опис очікуваних результатів 	|
|:-----:	|:-----:	|--------------------------------------------------------------------------------------------------------------------------------:	|-----------------------------	|
| FR1.1 	| TC1.1 	| Початкові умови: **користувач із заданим id існує**<br>Кроки:<br>1) login_email = "Test@gmail.com"<br>2) password = "password1" 	|        Результат = 1        	|
| FR1.1 	| TC1.2 	| Початкові умови: **відсутні**<br>Кроки:<br>1) login_email = "dd2"<br>2) password = "password2"                                  	|        Результат = -1       	|
| FR1.1 	| TC1.3 	| Початкові умови: **відсутні**<br>Кроки:<br>1) login_email = "користувач_one"<br>2) password = "password3"                       	|        Результат = -1       	|
| FR1.1 	| TC1.4 	| Початкові умови: **відсутні**<br>Кроки:<br>1) login_email = "☆ӲϭΪɮɑшӄа☆"<br>2) password = "password3"                           	|        Результат = -1       	|
| FR1.1 	| TC1.5 	| Початкові умови: **відсутні**<br>Кроки:<br>1) login_email = "SuperUser"<br>2) password = "12345"                                	|        Результат = -2       	|
| FR1.1 	| TC1.6 	| Початкові умови: **відсутні**<br>Кроки:<br>1) login_email = "admin@ukr.net"<br>2) password = "-2number1"                        	|        Результат = -2       	|