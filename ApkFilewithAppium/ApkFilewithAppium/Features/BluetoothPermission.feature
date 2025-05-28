Feature: BluetoothPermission

A short summary of the feature

@NAP @label:allure_id:1720251 @tms:1720251 @story:BluetoothPermission @parentSuite:BluetoothPermission @owner:QA
    Scenario: Verify option to request bluetooth permission
        Given I launch the plugin app
        And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
        Then verify 'Ok' is 'displayed' on 'BluetoothPermissionPluginPage'  
 
@NAP @label:allure_id:1720833 @tms:1720833 @story:BluetoothPermission @parentSuite:BluetoothPermission @owner:QA 
    Scenario: Verify option to open settings in bluetooth permission page
        Given I launch the plugin app
        And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
        And I press 'Ok' on 'BluetoothPermissionPluginPage'
        When I 'Don’t allow' permission request
        Then verify 'OpenSettings' is 'displayed' on 'BluetoothPermissionPluginPage'

@NAP @label:allure_id:1720835 @tms:1720835 @story:BluetoothPermission @parentSuite:BluetoothPermission @owner:QA
    Scenario: Verify bluetooth permissions granted already
        Given I launch the plugin app
        And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
        And I press 'Ok' on 'BluetoothPermissionPluginPage'
        When I 'Don’t allow' permission request
        Then verify plugin is completed

@NAP @label:allure_id:1720846 @tms:1720846 @story:BluetoothPermission @parentSuite:BluetoothPermission @owner:QA
    Scenario: Verify rationale on granting the bluetooth permissions
        Given I launch the plugin app
        When I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
        Then verify 'PermissionHeader' is 'displayed' on 'BluetoothPermissionPluginPage'
        And verify 'PermissionBody' is 'displayed' on 'BluetoothPermissionPluginPage'

@NAP @label:allure_id:1720907 @tms:1720907 @story:BluetoothPermission @parentSuite:BluetoothPermission @owner:QA
    Scenario: Verify bluetooth permission request through OS
        Given I launch the plugin app
        And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
        When I press 'Ok' on 'BluetoothPermissionPluginPage'
        Then verify permission request alert is displayed and close alert

@NAP @label:allure_id:1720926 @tms:1720926 @story:BluetoothPermission @parentSuite:BluetoothPermission @owner:QA
    Scenario: Verify bluetooth permission is granted through OS
        Given I launch the plugin app
        And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
        When I press 'Ok' on 'BluetoothPermissionPluginPage'
        When I 'Don’t allow' permission request
        Then verify plugin is completed 

@NAP @label:allure_id:1720927 @tms:1720927 @story:BluetoothPermission @parentSuite:BluetoothPermission @owner:QA 
    Scenario: Verify rationale on not granting the bluetooth permissions
        Given I launch the plugin app
        And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
        When I press 'Ok' on 'BluetoothPermissionPluginPage'
        When I 'Don’t allow' permission request
        Then verify 'PermissionHeader' is 'displayed' on 'BluetoothPermissionPluginPage'
        And verify 'PermissionBody' is 'displayed' on 'BluetoothPermissionPluginPage'

@NAP @label:allure_id:1742944 @tms:1742944 @story:BluetoothPermission @parentSuite:BluetoothPermission @owner:QA @Android
    Scenario: Verify the app settings are displayed through OS for bluetooth permissions for Android
        Given I launch the plugin app
        And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
        When I press 'Ok' on 'BluetoothPermissionPluginPage'
        When I 'Don’t allow' permission request
        And I press 'OpenSettings' on 'BluetoothPermissionPluginPage'
        Then verify 'Permissions' is 'displayed' on 'NativeSettingsPage'

@NAP @label:allure_id:1742994 @tms:1742994 @story:BluetoothPermission @parentSuite:BluetoothPermission @owner:QA @Android
    Scenario: Verify permission flow is completed on granting bluetooth for Android
        Given I launch the plugin app
        And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
        When I press 'Ok' on 'BluetoothPermissionPluginPage'
        When I 'Don’t allow' permission request
        And I close and restart the TestSinglePluginApp
        And I press 'OpenSettings' on 'BluetoothPermissionPluginPage'
        And I press 'Permissions' text on 'NativeSettingsPage'
        And I scroll 'Down' and press 'Nearby devices' on 'NativeSettingsPage'
        And I press 'Allow' button on 'NativeSettingsPage'
        Then verify plugin is completed

 @NAP @label:allure_id:1742928 @tms:1742928 @story:BluetoothPermission @parentSuite:BluetoothPermission @owner:QA @Android
    Scenario: Verify permission flow is not proceeded on denying bluetooth for Android
        Given I launch the plugin app
        And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
        When I press 'Ok' on 'BluetoothPermissionPluginPage'
        When I 'Don’t allow' permission request
        And I press 'OpenSettings' on 'BluetoothPermissionPluginPage'
        And I press 'Permissions' text on 'NativeSettingsPage'
        And I scroll 'Down' and press 'Nearby devices' on 'NativeSettingsPage'
        And I press 'Don’t allow' button on 'NativeSettingsPage'
        Then verify plugin is completed
 
@NAP @label:allure_id:1720928 @tms:1720928 @story:BluetoothPermission @parentSuite:BluetoothPermission @owner:QA
    Scenario: Verify flow is completed on denying through OS for bluetooth permission
        Given I launch the plugin app
        And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
        When I press 'Ok' on 'BluetoothPermissionPluginPage'
        And I 'Don’t allow' permission request
        And I terminate and relaunch the plugin app
        Then verify plugin is completed




        
        