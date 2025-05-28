Feature: bluetoothpermission
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](BluetoothPermission/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@tag1
Scenario: Verify option to request bluetooth permission
	 Given I launch the plugin app
	 And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
     Then verify 'Ok' is 'displayed' on 'BluetoothPermissionPluginPage'

@tag1
Scenario: Verify option to open settings in bluetooth permission page
     Given I launch the plugin app
     And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
     And I press 'Ok' on 'BluetoothPermissionPluginPage'
     When I 'Deny' permission request
     Then verify 'OpenSettings' is 'displayed' on 'BluetoothPermissionPluginPage'

@tag1
Scenario: Verify bluetooth permissions granted already
     Given I launch the plugin app
     And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
     And I press 'Ok' on 'BluetoothPermissionPluginPage'
     When I 'Grant' permission request
     And I terminate and relaunch the plugin app
     And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
     Then verify plugin is completed 

@tag1
 Scenario: Verify rationale on granting the bluetooth permissions
        Given I launch the plugin app
        When I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
        Then verify 'BluetoothPermissionHeader' is 'displayed' on 'BluetoothPermissionPluginPage'
        And verify 'BluetoothPermissionBody' is 'displayed' on 'BluetoothPermissionPluginPage'

@tag1
 Scenario: Verify bluetooth permission request through OS
        Given I launch the plugin app
        And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
        And I press 'Ok' on 'BluetoothPermissionPluginPage'
        Then verify permission request alert is displayed and close alert
@tag1
Scenario: Verify bluetooth permission is granted through OS
        Given I launch the plugin app
        And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
        And I press 'Ok' on 'BluetoothPermissionPluginPage'
        When I 'Grant' permission request
        Then verify plugin is completed 

@tag1
 Scenario: Verify rationale on not granting the bluetooth permissions
        Given I launch the plugin app
        And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
        And I press 'Ok' on 'BluetoothPermissionPluginPage'
        When I 'Deny' permission request
        Then verify 'Bluetooth permission app settings header' is 'displayed' on 'BluetoothPermissionPluginPage'
        And verify 'OpenSettingsPermissionBody' is 'displayed' on 'BluetoothPermissionPluginPage'

@tag1
 Scenario: Verify the app settings are displayed through OS for bluetooth permissions for Android
        Given I launch the plugin app
        And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
        And I press 'Ok' on 'BluetoothPermissionPluginPage'
        When I 'Deny' permission request
        And I press 'OpenSettings' on 'BluetoothPermissionPluginPage'
        Then verify 'Permissions' is 'displayed' on 'BluetoothPermissionPluginPage'

@tag1
 Scenario: Verify permission flow is completed on granting bluetooth for Android
        Given I launch the plugin app
        And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
        And I press 'Ok' on 'BluetoothPermissionPluginPage'
        When I 'Deny' permission request
        And I relaunch the plugin app
        And I press 'OpenSettings' on 'BluetoothPermissionPluginPage'
        And I press 'Permissions' on 'BluetoothPermissionPluginPage'
        And I scroll 'Down' and press 'NearbyDevices' on 'BluetoothPermissionPluginPage'
        And I press 'NativeSettingsAllow' on 'BluetoothPermissionPluginPage'
        And I terminate and relaunch the plugin app
        And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
        Then verify plugin is completed

@tag1
 Scenario: Verify permission flow is not proceeded on denying bluetooth for Android
        Given I launch the plugin app
        And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
        And I press 'Ok' on 'BluetoothPermissionPluginPage'
        When I 'Deny' permission request
        And I press 'OpenSettings' on 'BluetoothPermissionPluginPage'
        And I press 'Permissions' on 'BluetoothPermissionPluginPage'
        And I scroll 'Down' and press 'NearbyDevices' on 'BluetoothPermissionPluginPage'
        And I press 'NativeSettingsDeny' on 'BluetoothPermissionPluginPage'
        And I relaunch the plugin app
        Then verify 'OpenSettings' is 'displayed' on 'BluetoothPermissionPluginPage'
@tag1
 Scenario: Verify flow is completed on denying through OS for bluetooth permission
        Given I launch the plugin app
        And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
        And I press 'Ok' on 'BluetoothPermissionPluginPage'
        When I 'Deny' permission request
        And I terminate and relaunch the plugin app
        Then verify plugin is completed