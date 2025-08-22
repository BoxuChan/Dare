using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dare.API.Dto;
using Dare.API.Dto.Group;
using Dare.API.Dto.User;
using Dare.API.SignalR;
using Microsoft.Extensions.Logging;

namespace Dare.WebAPI
{
    public sealed partial class ApiController : IDareHub, IDareHubClient
    {
        // --- IDareHub (server -> client) ---
        public Task Client_GroupChat(GroupChatDto dto)
        {
            Logger.LogInformation("Client_GroupChat received: {@dto}", dto);
            return Task.CompletedTask;
        }

        public Task Client_MoodlesShare(MoodlesDto dto)
        {
            Logger.LogInformation("Client_MoodlesShare received: {@dto}", dto);
            return Task.CompletedTask;
        }

        public Task Client_UpdateSupporterList(SupporterDto dto)
        {
            Logger.LogInformation("Client_UpdateSupporterList received: {@dto}", dto);
            return Task.CompletedTask;
        }

        public Task Client_UserApplyMoodlesByStatus(ApplyMoodlesByStatusDto dto)
        {
            Logger.LogInformation("Client_UserApplyMoodlesByStatus received: {@dto}", dto);
            return Task.CompletedTask;
        }

        public Task GroupChatServer(GroupChatDto dto)
        {
            Logger.LogInformation("GroupChatServer called with: {@dto}", dto);
            return Task.CompletedTask;
        }

        public Task MoodlesShare(MoodlesDto dto)
        {
            Logger.LogInformation("MoodlesShare called with: {@dto}", dto);
            return Task.CompletedTask;
        }

        public Task<List<PFinderDto>> RefreshPFinderList(UserDto dto)
        {
            Logger.LogInformation("RefreshPFinderList called with: {@dto}", dto);
            return Task.FromResult(new List<PFinderDto>());
        }

        public Task<bool> UpdatePFinder(PFinderDto dto)
        {
            Logger.LogInformation("UpdatePFinder called with: {@dto}", dto);
            return Task.FromResult(true);
        }

        public Task UserReportProfile(UserProfileReportDto dto)
        {
            Logger.LogInformation("UserReportProfile called with: {@dto}", dto);
            return Task.CompletedTask;
        }

        // --- IDareHubClient (client-side hooks) ---
        public void OnMoodlesShare(Action<MoodlesDto> action)
        {
            Logger.LogInformation("OnMoodlesShare hook registered");
        }

        public void OnReceiveGroupChat(Action<GroupChatDto> action)
        {
            Logger.LogInformation("OnReceiveGroupChat hook registered");
        }

        public void OnSupporterUpdate(Action<SupporterDto> action)
        {
            Logger.LogInformation("OnSupporterUpdate hook registered");
        }

        public void OnUserApplyMoodlesByStatus(Action<ApplyMoodlesByStatusDto> action)
        {
            Logger.LogInformation("OnUserApplyMoodlesByStatus hook registered");
        }
    }
}