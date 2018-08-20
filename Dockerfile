# ==================================
# Build
# ==================================
FROM microsoft/dotnet:2.1-sdk as build

# copy the source
COPY ./src/ /build/

RUN dotnet publish \
    --framework netcoreapp2.1 \
    /build/SigTermTest.csproj \
    --output /out/

# ==================================
# Image
# ==================================
FROM microsoft/dotnet:2.1-runtime

#C copy the binaries
COPY --from=build /out/ /opt/sigtermtest/

# start it up
CMD ["dotnet", "/opt/sigtermtest/SigTermTest.dll"]