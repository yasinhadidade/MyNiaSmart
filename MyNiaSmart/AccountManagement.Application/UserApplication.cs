﻿using _0_Framework;
using _0_Framework.Contract;
using _0_Framework.Utilities;
using _01_Framework.Application;
using AccountManagement.Application.Contract.User;
using AccountManagement.Domain.UserAgg;
using AccountManagement.Domain.UserPersonalityAgg;
using System;
using System.Collections.Generic;

namespace AccountManagement.Application
{
    public class UserApplication : IUserApplication
    {
        private readonly IUserRepository _userRepository;
        private readonly IFileUploader _fileUploader;
        private readonly IUserPersonalityRepository _userPersonalityRepository;
        private readonly IAuthHelper _authHelper;

        public UserApplication(IUserRepository userRepository, IFileUploader fileUploader,
            IUserPersonalityRepository userPersonalityRepository, IAuthHelper authHelper)
        {
            _userRepository = userRepository;
            _fileUploader = fileUploader;
            _userPersonalityRepository = userPersonalityRepository;
            _authHelper = authHelper;
        }

        public OperationResult Create(CreateUser command)
        {
            var operation = new OperationResult();
            if (_userRepository.IsExist(x => x.MobileNumber == command.MobileNumber))
                return operation.Failed(ApplicationMessage.DuplicatedRecord);

            var birthday = DateTime.MinValue;
            if (command.Birthday != null)
                birthday = command.Birthday.ToGeorgianDateTime();



            var picturePath = _fileUploader.Upload(command.ProfilePhoto, "UserPhoto");
            var user = new User(command.FullName, command.MobileNumber
                , command.Capital, command.City, command.Address, command.NationalCode
                , birthday, picturePath, command.IntroductorFullname, command.IntroductorMobileNumber, command.Experience);
            _userRepository.Create(user);
            _userRepository.Savechange();

            //TO set new user as a client, we add a record in userPersonalityTable for this user
            var userPersonality = new UserPersonality(user.Id, PersonalityTitle.Client);
            _userPersonalityRepository.Create(userPersonality);
            _userPersonalityRepository.Savechange();

            return operation.Succedded();

        }

        public OperationResult Edit(EditUser command)
        {
            var operation = new OperationResult();
            var user = _userRepository.GetById(command.Id);
            if (user == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            if (_userRepository.IsExist(x => x.MobileNumber == command.MobileNumber && x.Id != command.Id))
                return operation.Failed(ApplicationMessage.DuplicatedRecord);

            var birthday = DateTime.MinValue;
            if (command.Birthday != null)
                birthday = command.Birthday.ToGeorgianDateTime();

            var picturePath = _fileUploader.Upload(command.ProfilePhoto, "UserPhoto");

            user.Edit(command.FullName, command.MobileNumber
                , command.Capital, command.City, command.Address, command.NationalCode
                , birthday, picturePath, command.IntroductorFullname, command.IntroductorMobileNumber, command.Grade, command.Experience);
            _userRepository.Savechange();
            return operation.Succedded();
        }
        public OperationResult RegisterOrLogin(RegisterOrLoginUser command)
        {
            var operation = new OperationResult();
            var account = _userRepository.GetUserByMobileNumber(command.MobileNumber);
            //اگر کاربر جدید و نام کاربری را وارد نکرده
            if (account == null && command.FullName == null)
                return operation.Failed("شما به عنوان کاربر جدید،باید نام و نام خانوادگی هم پر کنید");

            // اگر شماره همراه ثبت و با نام جدید لاگین شود
            if(account!=null)
            {
                if (command.FullName != null && account.FullName != command.FullName)
                    return operation.Failed("شماره همراه با نام کاربری متابقت ندارد");
            }

            //اگر کاربر جدید است و میخواهد ثبت نام کند 
            if (account == null && command.FullName != null)
            {
                account = new User(command.FullName, command.MobileNumber);
                _userRepository.Create(account);
                _userRepository.Savechange();
                account.GenerateActiveCode(GenerateUniqueCode.GenerateRandomNo());
                var value = account.ActiveCode;

                //ToDo Sending Sms With Verification Code then we will change active code
                string[] p = { "KarmandName", "SenderName", "Url" };
                string[] v = { value, "نام مشتری", "url Value" };

                string pValue = "";
                string vValue = "";
                for (int i = 0; i < p.Length; i++)
                {
                    pValue = pValue + "p" + (i + 1) + "=" + p[i] + "&";
                    vValue = vValue + "v" + (i + 1) + "=" + v[i] + "&";
                }
                SendPattern.SendSms("h5a27unwzlk3p0t", command.MobileNumber, pValue, vValue);
                _userRepository.Savechange();
                return operation.Succedded();
            }

            //اگر شماره همراه ثبت و کاربر میخواهد لاگین شود
            var newvalue = account.ActiveCode;
            string[] pp = { "KarmandName", "SenderName", "Url" };
            string[] vv = { newvalue, "نام مشتری", "url Value" };

            string ppValue = "";
            string vvValue = "";
            for (int i = 0; i < pp.Length; i++)
            {
                ppValue = ppValue + "p" + (i + 1) + "=" + pp[i] + "&";
                vvValue = vvValue + "v" + (i + 1) + "=" + vv[i] + "&";
            }

            SendPattern.SendSms("h5a27unwzlk3p0t", account.MobileNumber, ppValue, vvValue);
            _userRepository.Savechange();
            return operation.Succedded();

        }
        public OperationResult CheckVerificationCode(VerificationCode command)
        {
            var operation = new OperationResult();
            var account = _userRepository.GetUserByActiveCode(command.Code);
            if (account==null)
                return operation.Failed("کد وارد شده معتبر نیست");

            //حالتی که شانسی یه کد وارد کنه ولی اتفاقی مال یه نفز دیگه باشه. احتمال یک یه )
            if(account!=null && account.ActiveCode!=command.Code)
                return operation.Failed("کد وارد شده معتبر نیست");


            //ToChangeAccountInformation
            account.ActiveUser();
            account.GenerateActiveCode(GenerateUniqueCode.GenerateRandomNo());
            _userRepository.Savechange();

            //Login Operation
            var authViewModel = new AuthViewModel(account.Id, account.FullName, account.MobileNumber);
            _authHelper.Signin(authViewModel);
            return operation.Succedded();
        }

        public EditUser GetDetails(long id)
        {
            return _userRepository.GetDetails(id);
        }

        public List<UserViewModel> GetList()
        {
            return _userRepository.GetList();
        }

        public void LogOut()
        {
            _authHelper.SignOut();

        }
    }
}
