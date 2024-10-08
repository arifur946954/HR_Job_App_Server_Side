using System;
using System.Collections.Generic;
using System.Text;

namespace DataUtility
{
    public class MessageConstants
    {
        public const string DataNotFind = "No Data Found.";
        public const string ReopenMessage = "Lead is reopened successfully.";
        public const string Saved = "Saved Successfully.";
        public const string CaptchaError = "Captcha Verification Error.";
        public const string SavedWarning = "No Data Saved.";
        public const string TenantUserWarning = "Tenant is invalid.";
        public const string SubTenantUserWarning = "Sub Tenant is invalid.";
        public const string TrialToCommercialSuccess = "VM is successfully converted from trial to commercial.";
        public const string TrialToCommercialFailed = "Trial to commercial conversion is failed.Please try again.";
        public const string SavedPartiallySuccessfull = "Data Saved sucessfully to Cloud Center.But no data saved to ERP.Please sync data.";
        public const string SavedPartiallySuccessfullToISP = "Data Saved sucessfully to ISP. But no data saved to ERP. Please sync data.";
        public const string ConnectionNotFound = "Remote server is busy or down. Connection not found. Please try again later.";
        public const string GatewayTimeOut = "Gateway Time Out in CISCO API server.Remote server didn't response in time.Please contact with system administrator.";
        public const string Updated = "Updated Successfully.";
        public const string UpdateWarning = "No Data Updated.";
        public const string Deleted = "Deleted Successfully.";
        public const string DeletedWarning = "No Data Deleted.";
        public const string Exist = "Data already exist.";
        public const string NotExist = "Data does not exist.";
        public const string CodeExist = "Code already exist.";
        public const string ProcessFlowExist = "Process flow already exist.";
        public const string Auth = "Authentication Successful.";
        public const string AuthWarning = "Authentication Error.";
        public const string Sync = "Data Synced Successfully.";
        public const string SyncWarning = "Data Not Synced.";
        public const string Start = "Start Successfully.";
        public const string Suspend = "Suspended Successfully.";
        public const string Resume = "Resumed Successfully.";
        public const string SuspendFailed = "Suspension failed.";
        public const string ResumeFailed = "Resumed failed.";
        public const string StartWarning = "VM is not Started.";
        public const string InsufficientBalance = "Current balance is insufficient.";
        public const string Stop = "Stop Successfully.";
        public const string StopWarning = "VM is not Stopped.";
        public const string Terminated = "Terminated Successfully.";
        public const string TerminatedWarning = "VM is not terminated.";
        public const string Reboot = "Reboot Successfully.";
        public const string RebootWarning = "VM is not Rebooted.";

        public const string Payment = "Payment successfully completed.";
        public const string PaymentWarning = "You have no sufficient balance.";
        public const string PaymentError = "Payment not completed.";
        public const string PaymentIncomplete = "Payment process Incomplete.";
        public const string PaymentErrorNouser = "Payment not completed, No User Found.";

        public const string Recharge = "Recharge successfully completed.";
        public const string RechargeWarning = "Recharge not completed.";
        public const string RechargeNotDone = "Registration is completed.But recharge is not completed.";

        public const string OpBalance = "Opening balance set successfully completed.";
        public const string OpBalanceWarning = "Opening balance not completed.";

        public const string SyncNoData = "No data found to sync.";
        public const string MailSuccess = "Mail is sent successfully";
        public const string MailWarning = "No mail sent, please try again...";
        public const string InvalidMail = "Invalid Email Address...";
        public const string MailTemplate = "Mail Template not found.";
        public const string FoundPackage = "Your desired package under selected profile already exist, Please try another!!!";
        public const string UserCreated = "User created successfully.";
        public const string vmDeployWarning = "VM deployment is not possible with chanaged OS and given configuration.";
        public const string vmDeployDelayWarning = "VM deployment is processing...";
        public const string vmUserDeleted = "VM and User Deleted Successfully.";
        public const string ServerDown = "Cloud server is down.";
        public const string IspServerDown = "ISP server is down.";
        public const bool SuccessState = true;
        public const bool ErrorState = false;
        public const string AlreadyExist = "Already a Schedule fixed";
        public const string ApprovalStateSuccess = "Approval State updated successfully done";
        public const string ApprovalWarning = "Approval State not updated.";
        public const string FinanceYearWarning = "Inputed date must be between financial year. Please try again!!!";
        public const string SelectRegionWarning = "Please select minimum 1 region.";
        public const string CreatedButNotSent = "User created but sending email failed";
        public const string UsernameExist = "Username exist. Try another one";
        public const string PasswordChangeSuccess = "Password has changed successfully.";
        public const string PasswordResetSuccess = "Password has reset successfully.";
        public const string PasswordResetFailed = "Password has reset failed.";
        public const string TokenAuthenticationFailed = "User token is not authenticated.Please contact with system administrator";
        public const string UsernameNotExist = "User name does not exist.";
        public const string PasswordWrong = "Password is wrong.";
        public const string PasswordMatched = "Old Password is ok.";
        public const string VmNotFound = "No VM found for the user.";
        public const string InstanceResizeSuccess = "Instance is resized successfully.";
        public const string InstanceResizeFailed = "Instance resizing failed.";
        public const string UsernameNotActive = "User not active.";
        public const string UserEnabled = "User enabled successfully.";
        public const string UserDisabled = "User disabled successfully.";
        public const string Import = "Imported Successfully";
        public const string ImportWarning = "No Data Imported.";
        public const string CouponApplied = "Coupon applied successfully.";
        public const string NoCouponApplied = "No Coupon applied.";
        public const string CouponWarning = "Coupon has been already applied.";
        public const string CouponInvalid = "Invalid coupon.";
        public const string UserHasAppliedCoupon = "User already has applied coupon.";
        public const string InvalidAccess = "Invalid access.";
        public const string Activated = "Activation Successful!";
        public const string AlreadyActivated = "User already activated!";
        public const string ActivatedWarning = "There is an error. Try later!";
        public const string subTenantActivationProfileWarning = "Please create a activation profile of selected sub-tenant!";
        public const string tenantActivationProfileWarning = "Please create a activation profile of selected tenant!";
        public const string ConversionFailed = "Conversion Failed";
        public const string ConversionSuccess = "Data converted successfully";
        public const string DataNotFound = "Data not found";
        public const string UserAlreadyExist = "Username already exist";
        public const string IspPackageExist = "ISP internet package already exist.";
        public const string IspServiceExist = "ISP service already exist.";
        public const string ApprovalProceedSuccess = "Successfully Proceeded";
        public const string ApprovalProceedError = "Failed to proceed";
        public const string ServiceRefreshing = "Refreshing service completed";
        public const string SDisconnect = "Successfully disconnected";
        public const string FDisconnect = "Failed to disconnect";
        public const string NoRadius = "Not a radius service";
        public const string TrialExtended = "Trial period is extended";
        public const string LoginSuccess = "Successfully logged in!!!";
        public const string LoginFailed = "Login failed!";

        public static string[] UserCloudActivityLogType = new string[]
        {
            "SignUp",
            "Login",
            "Logout",
            "Dashboard Load",
            "Profile Load",
            "Virtual Machine Load",
            "Virtual Machine Stop",
            "Virtual Machine Reboot",
            "Virtual Machine Terminate",
            "Virtual Machine View",
            "Payment Load",
            "Recharge",
            "Virtual Machine Start",
        };
        public const string PromoCodeExist = "Promo code already exist, try with new one.";
        public const string PromoCodeStartError = "Promo code start date should not be smaller than today.";
        public const string addSuccess = "added successfully.";
        public const string addfailed = "adding failed.";
        public const string changeSuccess = "changed successfully.";
        public const string changeFailed = "changing failed.";
        public const string removedSuccess = "removed successfully.";
        public const string removedFailed = "removing failed.";
        public const string attachedSuccess = "Volume attached successfully.";
        public const string attachedFailed = "Volume attached failed.";
        public const string dettachSuccess = "Volume detached successfully.";
        public const string dettachFailed = "Volume detached failed.";
        public const string ErrorMessage = "Error occurred.";
        public const string syncSuccess = "VM synced successfully.";
        public const string syncFailed = "VM sync failed.";

        public const string TicketSaved = "The Support case has been created, Please keep the case number for your records.!";
        public const string TicketDeleteWarning = "Unable to delete, the ticket in process!";
        public const string TicketEditWarning = "Unable to edit, the ticket in process!";
        public const string TicketResolve = "The Support case has been resolved.!";
        public const string TicketUndoResolve = "The Support case has been done dissolved.!";

        public const string EmailSent = "Email has been sent to your email address.";
        public const string EmailNotSent = "Email not sent.";
        public const string NoAccountFoundWithEmail = "No account has been created with this email address.";

        public const string RecoveryEmailSent = "Recovery email has been sent to your email address.";
        public const string RecoveryEmailNotSent = "Recovery email not sent.";

        public const string UnAuthorized = "No authority to perform this action.";

        public const string FileSuccess = "File uploaded successfully!!!";
        public const string FileError = "File uploaded failed!!!";

        #region validation message
        public const string ValidationMessageRequired = "should not be null or empty.";
        public const string ValidationMessageRang = "length must be between";

        /// <summary>
        /// ValidateMessageRequired is a method to build Validation Message for Required
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        public static string ValidateMessageRequired(string field)
        {
            return field + " " + ValidationMessageRequired;
        }

        /// <summary>
        /// ValidateMessageRang is a method to build Validation Message for Rang
        /// </summary>
        /// <param name="field"></param>
        public static string ValidateMessageRang(string field, int min, int max)
        {
            return field + " " + ValidationMessageRang + " " + min + " and " + max;
        }
        #endregion

        #region sales isp
        public const string CreateOpportunity = "Opportunity has been created.";
        #endregion

    }
}
