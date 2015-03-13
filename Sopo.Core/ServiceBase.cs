using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sopo.Repository;

namespace Sopo.Core
{
    public class ServiceBase
    {
        public ServiceBase()
        {
            _cityRepository = new CityRepository();
            _countryRepository = new CountryRepository();
            _groupRepository = new GroupRepository();
            _libraryRepository = new LibraryRepository();
            _logRepository = new LogRepository();
            _messageRepository= new MessageRepository();
            _pageRepository = new PageRepository();
            _phoneRepository= new PhoneRepository();
            _pictureRepository = new PictureRepository();
            _postRepository = new PostRepository();
            _profileRepository = new ProfileRepository();
            _ratingRepository = new RatingRepository();
            _relationshipRepository = new RelationshipRepository();
            _userRepository = new UserRepository();
            _downloadPathRepository = new DownloadPathRepository();
        }

        protected internal CityRepository _cityRepository;
        protected internal CountryRepository _countryRepository;
        protected internal GroupRepository _groupRepository;
        protected internal LibraryRepository _libraryRepository;
        protected internal LogRepository _logRepository;
        protected internal MessageRepository _messageRepository;
        protected internal PageRepository _pageRepository;
        protected internal PhoneRepository _phoneRepository;
        protected internal PictureRepository _pictureRepository;
        protected internal PostRepository _postRepository;
        protected internal ProfileRepository _profileRepository;
        protected internal RatingRepository _ratingRepository;
        protected internal RelationshipRepository _relationshipRepository;
        protected internal UserRepository _userRepository;
        protected internal DownloadPathRepository _downloadPathRepository;
    }
}
