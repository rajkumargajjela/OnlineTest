Feature: ShoeTests
  In order to test Shoe Test Website
  As an user
  I want to be be able to test all monthly brand shoe details

@ShoeTest
Scenario: Verify HOME Button on Landing Page
	Given Navigate to Shoe Store site
	And Click on "<Month>" menu link
	When "<Month>" page is loaded
	Then Click on HOME button on top left and verify HOME page

	Examples:
		| Month   |
		| January |

@ShoeTest
Scenario: Verify Choose a brand on Landing Page
	Given Navigate to Shoe Store site
	When Shoe Store is loaded
	Then Choose a brand lable should be displayed
	And Choose a brand dropdown should be displayed and the dropdown items should be morethan one
	And Choose a brand Search button should be displayed

@ShoeTest
Scenario: Verify All Months Menu Links including All Shoes and verify page Title
	Given Navigate to Shoe Store site
	When Click on "<Month>" menu link
	Then "<Month>" page is loaded
	And Verify Page Title Should Contains the "<Month>" name

	Examples:
		| Month     |
		| January   |
		| February  |
		| March     |
		| April     |
		| May       |
		| June      |
		| July      |
		| August    |
		| September |
		| October   |
		| November  |
		| December  |
		| All Shoes |

@ShoeTest
Scenario: Verify Shoe Brand Links in All Shoes page
	Given Navigate to Shoe Store site
	When Click on "All Shoes" menu link
	Then "All Shoes" page is loaded
	And Click on Brand "<Brand>" Name in All Shoes page
	Then "<Brand>" page is loaded

	Examples:
		| Brand             |
		| Jimmy Choo        |
		| Brian Atwood      |
		| Sergio Rossi      |
		| Charlotte Olympia |
		| Valentino         |
		| Miu Miu           |
		| Lanvin            |
		| Old Gringo        |
		| Prada             |
		| Gucci             |

@ShoeTest
Scenario: Verify Monthly Links in All Shoes page
	Given Navigate to Shoe Store site
	When Click on "All Shoes" menu link
	Then "All Shoes" page is loaded
	And Click on Brand "<Month>" Name in All Shoes page
	Then "<Month>" page is loaded

	Examples:
		| Month     |
		| January   |
		| February  |
		| March     |
		| April     |
		| May       |
		| June      |
		| July      |
		| August    |
		| September |
		| October   |
		| November  |

@ShoeTest
Scenario: Verify Remind me of new shoes email address validation in all pages
	Given Navigate to Shoe Store site
	When Click on "<Month>" menu link
	And Click on Remind me of new shoes Submit button
	Then We should receive a message with "Please enter an email address"
	When Enter an email address "<InvalidEmailAddress>"
	And Click on Remind me of new shoes Submit button
	Then We should receive a message with "Invalid email format. Ex. name@example.com"
	When Enter an email address "<ValidEmailAddress>"
	And Click on Remind me of new shoes Submit button
	Then We should receive a message with "Thanks! We will notify you of our new shoes at this email: <ValidEmailAddress>"

	Examples:
		| Month     | InvalidEmailAddress | ValidEmailAddress            |
		| January   | raj1!@#             | rajkumar.gajjela1@gmail.com  |
		| February  | raj2!@#             | rajkumar.gajjela2@gmail.com  |
		| March     | raj3!@#             | rajkumar.gajjela3@gmail.com  |
		| April     | raj4!@#             | rajkumar.gajjela4@gmail.com  |
		| May       | raj5!@#             | rajkumar.gajjela5@gmail.com  |
		| June      | raj6!@#             | rajkumar.gajjela6@gmail.com  |
		| July      | raj7!@#             | rajkumar.gajjela7@gmail.com  |
		| August    | raj8!@#             | rajkumar.gajjela8@gmail.com  |
		| September | raj9!@#             | rajkumar.gajjela9@gmail.com  |
		| October   | raj10!@#            | rajkumar.gajjela10@gmail.com |
		| November  | raj11!@#            | rajkumar.gajjela11@gmail.com |
		| December  | raj12!@#            | rajkumar.gajjela11@gmail.com |
		| All Shoes | raj13!@#            | rajkumar.gajjela11@gmail.com |

@ShoeTest
Scenario: Verify Notify me when this shoe is available email address validation in all pages
	Given Navigate to Shoe Store site
	When Click on "<Month>" menu link
	And Click on Notification Email Submit button
	Then We should receive a message with "Please enter an email address"
	When Enter a notification email address "<InvalidEmailAddress>"
	And Click on Notification Email Submit button
	Then We should receive a message with "Invalid email format. Ex. name@example.com"
	When Enter a notification email address "<ValidEmailAddress>"
	And Click on Notification Email Submit button
	Then We should receive a message with "Thanks! We will notify you when this shoe is available at this email: <ValidEmailAddress>"

	Examples:
		| Month     | InvalidEmailAddress | ValidEmailAddress            |
		| February  | raj2!@#             | rajkumar.gajjela2@gmail.com  |
		| March     | raj3!@#             | rajkumar.gajjela3@gmail.com  |
		| April     | raj4!@#             | rajkumar.gajjela4@gmail.com  |
		| May       | raj5!@#             | rajkumar.gajjela5@gmail.com  |
		| June      | raj6!@#             | rajkumar.gajjela6@gmail.com  |
		| July      | raj7!@#             | rajkumar.gajjela7@gmail.com  |
		| August    | raj8!@#             | rajkumar.gajjela8@gmail.com  |
		| September | raj9!@#             | rajkumar.gajjela9@gmail.com  |
		| October   | raj10!@#            | rajkumar.gajjela10@gmail.com |
		| November  | raj11!@#            | rajkumar.gajjela11@gmail.com |
		| All Shoes | raj13!@#            | rajkumar.gajjela11@gmail.com |

@ShoeTest
Scenario: Verify Choose a brand Validation on HOME Page
	Given Navigate to Shoe Store site
	When Click on Choose a brand Search button
	Then We should receive a message with "Please Select a Brand"
	Given Select some value from the dropdown "<Brand>"
	When Click on Choose a brand Search button
	Then "<Brand>" page is loaded

	Examples:
		| Brand                 |
		| ASICS®                |
		| Aquatalia by Marvin K |
		| Børn                  |
		| Brian Atwood          |
		| Flounce               |
		| House of Harlow 1960  |
		| Kalso Earth®          |
		| N.Y.L.A.              |
		| See by Chloé          |
		| UGG® Australia        |
		| Alice + Olivia        |

@ShoeTest
Scenario: Verify Shoe Brand Deails in all Month's pages
	Given Navigate to Shoe Store site
	When Click on "<Month>" menu link
	And "<Month>" page is loaded
	Then Validate Brand Details in Monthly pages "<Month>"

	Examples:
		| Month     |
		| January   |
		| February  |
		| March     |
		| April     |
		| May       |
		| June      |
		| July      |
		| August    |
		| September |
		| October   |
		| November  |
		| December  |