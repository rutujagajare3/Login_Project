using TechTalk.SpecFlow;
using SpecFlowProjectCustomerLogin;
using NUnit.Framework;


namespace SpecFlowProjectCustomerLogin.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefination
    {
        private string username;
        private string password;
        private string loginResult;
        private readonly ScenarioContext scenarioContext;
        private readonly CustomerLogin.Customerlogin customerlogin;
        public LoginStepDefination(ScenarioContext Sc)
        {
            this.scenarioContext = Sc;
            customerlogin = new CustomerLogin.Customerlogin();
        }
        [Given(@"a user with valid username ""([^""]*)"" and valid password ""([^""]*)"" ")]

       
        public void BeforeScenarioWithTag(string p0, string p1)
        {
            username = p0;
            password = p1;
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping

            //TODO: implement logic that has to run before executing each scenario
        }

        [When(@"the Login method is called")]
        public void FirstBeforeScenario()
        {
            loginResult = customerlogin.Login(username, password);
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
        }
        [Then(@"the result should Login success")]
        public void ThenBeforeScenario()
        {
            Assert.Equals("Login Success", loginResult);
        }


        [Given(@"a user with invalid username ""([^""]*)"" and invalid password ""([^""]*)"" ")]
        public void GivenAUserWithInvalidUsernameAndInvalidPassword(string p0, string invalid)
        {
            username = p0;
            username = invalid;
        }
        [Then(@"the result should Login Failed")]
        public void AfterScenario()
        {
            Assert.Equals("Login Failed", loginResult);  //TODO: implement logic that has to run after executing each scenario
        }
    }
}