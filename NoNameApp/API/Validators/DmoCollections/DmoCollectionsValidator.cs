﻿using API.DTO;
using API.DTO.DmoCollections;
using FluentValidation;
using Model;

namespace API.Validators.DmoCollections {
    // ReSharper disable UnusedMember.Global
    public class DmoCollectionsValidator : AbstractValidator<DmoCollectionShortDto> {
        public DmoCollectionsValidator() {
            RuleFor(d => d.CollectionName)
                .NotEmpty().WithMessage("Name of collection is missing")
                .MaximumLength(ApplicationConstants.MaxEntityNameLength)
                .WithMessage($"Maximum collection name length is {ApplicationConstants.MaxEntityNameLength}");
        }
    }

    public class AddDmoToCollectionDtoValidator : AbstractValidator<AddDmoToCollectionDto> {
        public AddDmoToCollectionDtoValidator() {
            RuleFor(d => d.DmoId).NotEmpty().WithMessage("Dmo id is missing");
            RuleFor(d => d.CollectionId).NotEmpty().WithMessage("Collection id is missing");
        }
    }

    public class CollectionNameDtoValidator : AbstractValidator<CollectionNameDto> {
        public CollectionNameDtoValidator() {
            RuleFor(d => d.CollectionId).NotEmpty().WithMessage("Collection id is missing");
        }
    }

    public class DeleteCollectionDtoValidator : AbstractValidator<DeleteCollectionDto> {
        public DeleteCollectionDtoValidator() {
            RuleFor(d => d.CollectionId).NotEmpty().WithMessage("Collection id is missing");
        }
    }

    public class DmoCollectionShortDtoValidator : AbstractValidator<DmoCollectionShortDto> {
        public DmoCollectionShortDtoValidator() {
            RuleFor(d => d.Id).NotEmpty().WithMessage("Collection id is missing");
            RuleFor(d => d.CollectionName).NotEmpty().WithMessage("Collection name is missing");
        }
    }

    public class GetCollectionDtoValidator : AbstractValidator<GetCollectionDto> {
        public GetCollectionDtoValidator() {
            RuleFor(d => d.CollectionId).NotEmpty().WithMessage("Collection id is missing");
        }
    }
    public class RemoveDmoFromCollectionDtoValidator : AbstractValidator<RemoveDmoFromCollectionDto> {
        public RemoveDmoFromCollectionDtoValidator() {
            RuleFor(d => d.CollectionId).NotEmpty().WithMessage("Collection id is missing");
            RuleFor(d => d.DmoId).NotEmpty().WithMessage("Dmo id is missing");
        }
    }
}