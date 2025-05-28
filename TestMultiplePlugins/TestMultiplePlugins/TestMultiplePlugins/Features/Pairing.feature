Feature: Pairing

A short summary of the feature

@tag1
Scenario: Verify restart hearing aids body in restart guide flow
	Given The user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user selects "pairingserviceprovider" and sets the configuration
	When the user presets the path to "happy"
	When user starts pairing the HIs
	Then verify if connected


Scenario: Verify flow completes on restarting HI in restart guide flow
	Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "nodevicesconnectedorknown"
	When user initiates restarting HIs
	Then verify if  rechargeable is displayed

Scenario: Verify option for guidance in restart guide flow
	Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "nodevicesconnectedorknown"
	When user initiates restarting HIs
	When user clicks Replaceable battery
	Then verify if the option clicked

Scenario:  Verify guide to turn on hearing aids in restart guide flow
	Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "nodevicesconnectedorknown"
	When user initiates restarting HIs
	When the user scrolls "down" and clicks on "custom"
	#When the user clicks customs
	Then verify if the option clicked

Scenario:  Verify option to search for rebooting hearing aid
	Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "nodevicesconnectedorknown"
	When the user cliks the restart button
	Then verify if "Searching" is displayed

Scenario:  Verify Confirm exit
	Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "nodevicesconnectedorknown"
	When the user cliks the restart button
	When user clicks close button
	Then verify "Exit" is displayed

Scenario:  Verify turn on hearing aids body when HIs are disconnected
	Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "mfinotfullyconnected"
	When user clicks "pairingplugin"
	Then verify the text "Turn on your hearing aids" is displayed

Scenario:  Verify option to pair new hearing aids in MFi already paired flow
	Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "mfinotfullyconnected"
	When user clicks "pairingplugin"
	Then verify text "Pair new hearing aids" is displayed

Scenario: Verify pair new hearing aids for already paired flow
	Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "mfifullyconnected"
	When user clicks "pairingplugin"
	Then verify 'Pair new hearing aids' is displayed

Scenario:  Verify pairing flow completed for Non-MFi already paired flow
    Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "nodevicesconnectedorknown"
	When user clicks "pairingplugin"
	Then verify the text "Restart hearing aids" displayed

Scenario: Verify Hearing aids are connected in MFi flow
    Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "mfifullyconnected"
	When user clicks "pairingplugin"
	Then verify if the text "“GN Hearing Aids” connected to this device." is displayed

 Scenario:  Verify option to pair new hearing aids in MFi flow
	Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "mfifullyconnected"
	When user clicks "pairingplugin"
	Then verify if the text "Pair new hearing aids" is being displayed

Scenario: Verify option to use found hearing aids in MFi flow
	Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "mfifullyconnected"
	When user clicks "pairingplugin"
	Then Verify the text "Connect" is seen

Scenario: Verify to remove the current hearing aids from the phone in MFi flow
	Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "mfifullyconnected"
	When user clicks "pairingplugin"
	When the user clicks "Pair new Hearing aids"  
	Then verify the texts displayed

Scenario: Verify option to open system settings in MFi flow
	Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "mfifullyconnected"
	When user clicks "pairingplugin"
	When the user clicks "Pair new Hearing aids"
	Then verify if the option "Open settings" is displayed

Scenario: Verify multiple hearing aids connected to app in Non MFi flow
	Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "morethanonedevice"
	When user clicks "pairingplugin"
	Then verify if  "Hearing aids connected" is displayed

Scenario: Verify option to use found hearing aids in Non MFi flow
	Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "morethanonedevice"
	When user clicks "pairingplugin"
	Then verify  if the "Connect" is displayed

Scenario:  Verify option to pair new hearing aids in Non MFi flow
	Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "morethanonedevice"
	When user clicks "pairingplugin"
	Then verify  if "Pair new hearing aids" is  displayed

Scenario: Verify Bluetooth permission flow completed
	Given I scroll "Down" and launch plugin 'BluetoothPermissionPlugin'
	When I press "Ok" on BluetoothPermissionPluginPage
	When I "Grant" permission request
	When I terminate and relaunch the plugin app
	When I scroll 'Down' and launch plugin "PairingPlugin"
	Then verify "Restart hearing aids" is displayed on RestartDevicesPage

Scenario: Verify Bluetooth permission flow is not completed when denying permission request
    Given I scroll "Down" and launch plugin 'BluetoothPermissionPlugin'
	When I press "Ok" on BluetoothPermissionPluginPage
	When I "Deny" permission request
	When I terminate and relaunch the plugin app
	When I scroll 'Down' and launch plugin "PairingPlugin"
	Then verify plugin is completed

 Scenario:Verify pairing flow when bluetooth is enabled
	Given I scroll "Down" and launch plugin 'BluetoothPermissionPlugin'
	When I press "Ok" on BluetoothPermissionPluginPage
	When I "Grant" permission request	
	When I go to native settings
	When I press 'Bluetooth' button on Settings Page and Turn 'OFF' bluetooth
	When I relaunch the plugin app 
	When I scroll 'Down' and launch plugin "PairingPlugin"
	Then verify 'Body1Description' is displayed on EnableBluetoothPluginPage

Scenario: :Verify pairing flow when bluetooth is enabledd
	Given I scroll "Down" and launch plugin 'BluetoothPermissionPlugin'
	When I press "Ok" on BluetoothPermissionPluginPage
	When I "Grant" permission request	
	When I go to native settings
	When I press 'Bluetooth' button on Settings Page and Turn 'ON' bluetooth
	When I relaunch the plugin app 
	When I scroll 'Down' and launch plugin "PairingPlugin"
	And I wait for "5" seconds
	Then verify "Restart hearing aids" is displayed on RestartDevicesPage

Scenario: Verify Turn on Bluetooth option in Enable Bluetooth flow when bluetooth disabled state
	Given I scroll "Down" and launch plugin 'BluetoothPermissionPlugin'
	When I press "Ok" on BluetoothPermissionPluginPage
	When I "Grant" permission request	
	When I go to native settings
	When I press 'Bluetooth' button on Settings Page and Turn 'OFF' bluetooth
	When I relaunch the plugin app 
	When I scroll 'Down' and launch plugin "PairingPlugin"
	Then verify "Turn On Bluetooth" is displayed on EnableBluetoothPluginPage

Scenario:  Verify option to connect when single HIs set found in pairing flow
	Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "completesetfound"
	When user clicks "pairingplugin"
	When the user press 'I have restarted them' on RestartDevicesPage with timeout '10'
	Then verify "Connect" is displayed on CompleteSetFoundPage

Scenario: Verify option to pair another HI when complete set found in pairing floww
	Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "completesetfound"
	When user clicks "pairingplugin"
	When the user press 'I have restarted them' on RestartDevicesPage with timeout '5'
	Then verify "Pair another device" is displayed on CompleteSetFoundPage

Scenario Outline: Verify the various options to connect one HI in pairing floww
	Given the user enables Dynamic service provider page after enabling '<Service>'
	When the user select "<ServiceProvider>" and sets the configuration
	When the user presetting the path to "<preset>"
	When user clicks "<PluginName>"
	When the user press 'I have restarted them' on RestartDevicesPage with timeout '10'
	Then verify "<Text>" is displayed on "<PageName>"
	Examples:
		  | Service                      | ServiceProvider        | PluginName    | Text                 | PageName              | preset           |
		  | Use Dynamic Service Provider | pairingserviceprovider | pairingplugin | Connect              | CompleteSetFoundPage  | completesetfound |
		  | Use Dynamic Service Provider | pairingserviceprovider | pairingplugin | Pair another device  | CompleteSetFoundPage  | completesetfound |

Scenario: Verify option to connect one HI in pairing flow
    Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "onlyrightofsetfound"
	When user clicks "pairingplugin"
	When the user press 'I have restarted them' on RestartDevicesPage with timeout '5'
	Then verify "Connect right side only" is displayed on LeftMissingPage

Scenario: Verify option to connect one HI inn pairing flow
    Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "onlyleftofsetfound"
	When user clicks "pairingplugin"
	When the user press 'I have restarted them' on RestartDevicesPage with timeout '5'
	Then verify "Connect left side only" is displayed on RightMissingPage

Scenario: Verify option to search again when one HI missing in pairing flow
	Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "onlyrightofsetfound"
	When user clicks "pairingplugin"
	When the user press 'I have restarted them' on RestartDevicesPage with timeout '5'
	Then verify "Search again" is displayed on LeftMissingPage

Scenario: Verify option to search again when one HI missing in pairing floww
    Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "onlyleftofsetfound"
	When user clicks "pairingplugin"
	When the user press 'I have restarted them' on RestartDevicesPage with timeout '5'
	Then verify "Search again" is displayed on RightMissingPage

 #Scenario: Verify all found HI sets are displayed in pairing flow
    #Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	#When the user select "pairingserviceprovider" and sets the configuration
	#When the user presetting the path to "NoDeviceThenTwoDevices"
	#When the user press 'I have restarted them' on RestartDevicesPage with timeout '5'
	#Then verify 'Found devices' is displayed on SearchResultListPage

Scenario:  Verify option to search again missing HI in pairing flow
    Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "onlyleftofsetfound"
	When user clicks "pairingplugin"
	When the user press 'I have restarted them' on RestartDevicesPage with timeout '5'
	When the user clicks the option "Search again" with the time "10"
	When the user selects the device
	Then verify if the option "Search again" is displayed on screen

Scenario: Verify option to search again missing left HI in pairing flow 
    Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "onlyrightofsetfound"
	When user clicks "pairingplugin"
	When the user press 'I have restarted them' on RestartDevicesPage with timeout '5'	
	When the user clicks the option "Search again" with  the time "10"
	When the user selects the device
	Then verify if the option "Search again" is displayed on  screen

 Scenario Outline: Verify the various options to connect one HI in different pairing flows
	Given the user enables Dynamic service provider page after enabling '<Service>'
	When the user select "<ServiceProvider>" and sets the configuration
	When the user presetting the path to "<preset>"
	When user clicks "<PluginName>"
	When the user press 'I have restarted them' on RestartDevicesPage with timeout '10'
	Then verify "<Text>" is displayed on  "<PageName>"
	Examples:
		  | Service                      | ServiceProvider        | PluginName    | Text                    | PageName          | preset           |
		  | Use Dynamic Service Provider | pairingserviceprovider | pairingplugin | Connect right side only | LeftMissingPage   | onlyrightofsetfound |
		  | Use Dynamic Service Provider | pairingserviceprovider | pairingplugin | Connect left side only  | RightMissingPage  | onlyleftofsetfound |

Scenario: Verify the option to check if hearing aids are connected in Non MFi flow
    Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "switchesconnectedstateofonedevice"
	When user clicks "pairingplugin"
	And I wait '5' second
	Then verify the string "“My HIs” connected to this device." is displayed

Scenario:  Verify the option to check if hearing aids are connected for MFi flow
    Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "mfinotconnectedswitchestoconnected"
	When user clicks "pairingplugin"	
	And I wait '10' second
	Then Verify the text "“GN Hearing Aids” connected to this device." is displayed

Scenario: Verify restart hearing aids body in trusted bond flow
    Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "nodevicesconnectedorknown"
	When user clicks "pairingplugin"
	When the user press 'I have restarted them' on RestartDevicesPage
	When I click "Connect" on CompleteSetFoundPage with timeout "10"
	When I click on "Continue" on WaitingForBootPage with timeout "10"
	Then verify "Well done" is  displayed

 Scenario:  Verify option to restart hearing aids in trusted bond flow
 	Given the user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user select "pairingserviceprovider" and sets the configuration
	When the user presetting the path to "mfifullyconnected"
	When user clicks "pairingplugin"
	When the user clicks "Connect"
	When I click on "Continue" on WaitingForBootPage with timeout "10"
	Then verify "Well done" is  displayed

   Scenario: Verify trusted bond pairing completed successfully
   	Given The user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user selects "pairingserviceprovider" and sets the configuration
	When the user presets the path to "happy"
	When user clicks "pairingplugin"
	When the user clicks "Connect"
	When I click on "Continue" on WaitingForBootPage with timeout "25"
	Then verify "Well done" is  displayed
	Then verify "You are all set" is  displayed

 Scenario: Verify option to troubleshooting help on restarting HIs in trusted bond flow
    Given The user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user selects "pairingserviceprovider" and sets the configuration
	When the user presets the path to "timeoutwhendisconnecting"
	When user clicks "pairingplugin"
	When the user clicks "Connect" on MFiFullyConnectedPage with timeout '15'
	Then verify "Connection failed" is displayed on ConnectionFailedPage

Scenario: : Verify option to troubleshoot help on restarting HIs in trusted bond flow
    Given The user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user selects "pairingserviceprovider" and sets the configuration
	When the user presets the path to "timeoutwhendisconnecting"
	When user clicks "pairingplugin"
	When the user clicks "Connect" on MFiFullyConnectedPage with timeout '10'
	Then verify "Need more help" is displayed on ConnectionFailedPage

 Scenario: Verify option to continue in trusted bonded flow
    Given The user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user selects "pairingserviceprovider" and sets the configuration
	When the user presets the path to "happy"
	When user clicks "pairingplugin"
	When the user clicks "Connect"
	When I click on "Continue" on WaitingForBootPage with timeout "10"
	When I clicked on "Continue" on TrustedBondpage
	Then verify plugin is completed

 Scenario: Verify accept pairing body on connecting HI in connecting flow
	Given The user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user selects "pairingserviceprovider" and sets the configuration
	When the user presets the path to "simulatedpairingrequest"
	When user clicks "pairingplugin"
	When the user clicks "Connect" on MFiFullyConnectedPage with timeout '5'
	When the user clicks "Cancel" on AcceptPairingRequest with timeout "10"
	Then verify "Please accept"  displays on AcceptPairingRequestPage

Scenario: Verify option to retry pairing in connection flow
	Given The user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user selects "pairingserviceprovider" and sets the configuration
	When the user presets the path to "simulatedpairingrequest"
	When user clicks "pairingplugin"
	When the user clicks "Connect" on MFiFullyConnectedPage with timeout '5'
	When the user clicks "Cancel" on AcceptPairingRequest with timeout "10"
	When the user clicks "Continue" on AcceptPairingRequestPage
	When the user clicks "Cancel" on AcceptPairing request
	Then verify 'Try again' is displayed on BondingToPhoneFailedPage

   Scenario: Verify bonding failed header in connecting flow
   	Given The user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user selects "pairingserviceprovider" and sets the configuration
	When the user presets the path to "simulatedpairingrequest"
	When user clicks "pairingplugin"
	When the user clicks "Connect" on MFiFullyConnectedPage with timeout '5'
	When the user clicks "Cancel" on AcceptPairingRequest with timeout "10"
	When the user clicks "Continue" on AcceptPairingRequestPage
	When the user clicks "Cancel" on AcceptPairing request
	Then verify 'Pairing failed' is displayed on BondingToPhoneFailedPage

 Scenario: Verify option to try again in connecting flow
    Given The user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user selects "pairingserviceprovider" and sets the configuration
	When the user presets the path to "timeoutwhenstartingtrustedbond"
	When user clicks "pairingplugin"
	When the user clicks "Connect" on MFiFullyConnectedPage with timeout '3'
	Then verify "Try again" is displayed on ConnectionFailedPage

 Scenario: Verify to check disconnection of the hearing aids
    Given The user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user selects "pairingserviceprovider" and sets the configuration
	When the user presets the path to "timeoutwhenstartingtrustedbond"
	When user clicks "pairingplugin"
	When the user clicks "Connect" on MFiFullyConnectedPage with timeout '3'
	Then verify "Connection failed" is displayed on ConnectionFailedPage

  Scenario: Verify to Inform user that the app is connecting to the hearing aid
      Given The user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user selects "pairingserviceprovider" and sets the configuration
	When the user presets the path to "happy"
	When user clicks "pairingplugin"
	When the user clicks "Connect" on MFiFullyConnectedPage with timeout '5'
	When I click on "Continue" on WaitingForBootPage with timeout "5"
	Then verify "Well done" is  displayed

  Scenario: Verify to check connection and reading device data from the hearing aids
     Given The user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	 When the user selects "pairingserviceprovider" and sets the configuration
	 When the user presets the path to "happy"
	 When user clicks "pairingplugin"
	 When the user clicks "Connect" on MFiFullyConnectedPage with timeout '5'
	 When I click on "Continue" on WaitingForBootPage with timeout "5"
	 Then verify "Well done" is  displayed
	 Then verify "You are all set" is  displayed

Scenario: Verify to handle OS pairing request
   	Given The user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user selects "pairingserviceprovider" and sets the configuration
	When the user presets the path to "simulatedpairingrequest"
	When user clicks "pairingplugin"
	When the user clicks "Connect" on MFiFullyConnectedPage with timeout '5'
	 Then verify 'Pair device?' is displays

Scenario: Verify to accept pairing request
    Given The user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user selects "pairingserviceprovider" and sets the configuration
	When the user presets the path to "simulatedpairingrequest"
	When user clicks "pairingplugin"
	When the user clicks "Connect" on MFiFullyConnectedPage with timeout '5'
	When the user clicks "Pair" on AcceptPairingRequest with timeout "1"
	Then verify "Connected" is displayed on WaitingForBootPage

 Scenario: Verify to inform user that the hearing aids are connected
    Given The user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user selects "pairingserviceprovider" and sets the configuration
	When the user presets the path to "happy"
	When user clicks "pairingplugin"
	When the user clicks "Connect" on MFiFullyConnectedPage with timeout '5'
	Then verify "Connected" is displayed on WaitingForBootPage

Scenario: Verify to inform user that the hearing aids are connected, give option to continue
    Given The user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	When the user selects "pairingserviceprovider" and sets the configuration
	When the user presets the path to "happy"
	When user clicks "pairingplugin"
	When the user clicks "Connect" on MFiFullyConnectedPage with timeout '5'
	Then verify "Continue" is displayed on WaitingForBootPage

#Scenario:  Verify to check for MFi devices in pairing flow
	#Given The user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	#When the user selects "pairingserviceprovider" and sets the configuration
	#When the user presets the path to "NoPairedHIs"
	#When user clicks "pairingplugin"
	#When the user clicks "Connect" on MFiFullyConnectedPage with timeout '0'
	#Then verify "Pair your hearing aids" is displayed on MFiPairingGuidePage

#Scenario:  Verify to handle unsupported hearing aids
    #Given The user enables Dynamic service provider page after enabling 'Use Dynamic Service Provider'
	#When the user selects "pairingserviceprovider" and sets the configuration
	#When the user presets the path to "UnsupportedHIs"
	#When user clicks "pairingplugin"
	#When the user clicks "Connect" on MFiFullyConnectedPage with timeout '5'
	#Then verify "Hearing aids not compatible" is displayed on DevicesNotMadeByGNPage
