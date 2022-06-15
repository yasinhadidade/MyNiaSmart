﻿using _0_Framework.Contract;
using _0_Framework.Utilities;
using _01_Framework.Application;
using ShopManagement.Application.Contract.SellerProductMedia;
using ShopManagement.Domain.SellerProductMediaAgg;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Application
{
    public class SellerProductMediaApplication : ISellerProductMediaApplication
    {
        private readonly ISellerProductMediaRepository _sellerProductMediaRepository;
        private readonly IAuthHelper _authHelper;
        private readonly IFileUploader _fileUploader;

        public SellerProductMediaApplication(ISellerProductMediaRepository sellerProductMediaRepositoryl,
            IAuthHelper authHelper, IFileUploader fileUploader)
        {
            _sellerProductMediaRepository = sellerProductMediaRepositoryl;
            _authHelper = authHelper;
            _fileUploader = fileUploader;
        }

        public OperationResult CreateMediaForGallery(CreateMediaForSellerGallery command)
        {
            var operation = new OperationResult();
            var userMobile = _authHelper.CurrentAccountInfo().Mobile;
            var userId = _authHelper.CurrentAccountInfo().Id;

            //TO Do : check extension of files that are uploading and return error to client if its not png or jpg or video
            var extention = Path.GetExtension(command.Media.FileName);
            if (extention == ".png" || extention == ".jpg")
            {
                var picturePath = _fileUploader.Upload(command.Media, $"SellerProductMedias//{userMobile}");
                var sellerProductMedia = new SellerProductMedia(picturePath, userId);
                _sellerProductMediaRepository.Create(sellerProductMedia);
                _sellerProductMediaRepository.Savechange();
                return operation.SucceddedWithId("آپلود موفقیت آمیز بود",sellerProductMedia.Id);
            }
            return operation.Failed("باید png و یا jpg باشد");
        }

        public SellerGalleryViewModel GetMediaById(long id)
        {
            return _sellerProductMediaRepository.GetMediaById(id);
        }

        public List<long> GetSelectedMediaIdsOfSellerProductBySellerProductIdAndUserId(long sellerProductId, long userId)
        {
            return _sellerProductMediaRepository.GetSelectedMediaIdsOfSellerProductBySellerProductIdAndUserId(sellerProductId, userId);
        }

        public List<SellerGalleryViewModel> GetUserGalleryMediasByUserId(long userId)
        {
            return _sellerProductMediaRepository.GetUserGalleryMediasByUserId(userId);
        }
    }
}
