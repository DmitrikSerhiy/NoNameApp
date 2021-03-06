﻿using AutoMapper;
using Model.DTOs.Editor;
using Model.Entities;

namespace API.Features.Editor.Mappers {
    // ReSharper disable once UnusedMember.Global
    public class DmoMapper : Profile {
        public DmoMapper() {

            CreateMap<CreateDmoDto, Dmo>();
            CreateMap<Dmo, CreatedDmoDto>();

            CreateMap<UpdateShortDmoDto, Dmo>();

            CreateMap<LoadShortDmoDto, Dmo>();
            CreateMap<Dmo, LoadedShortDmoDto>()
                .ForMember(d => d.HasBeats, ld => ld
                    .MapFrom(lsd => !string.IsNullOrEmpty(lsd.BeatsJson)));
        }
    }
}
