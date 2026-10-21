# frozen_string_literal: true

Gem::Specification.new do |spec|
  spec.name          = "apiverve_weatherforecast"
  spec.version       = "1.2.2"
  spec.authors       = ["APIVerve"]
  spec.email         = ["hello@apiverve.com"]

  spec.summary       = "Weather API - Ruby Client"
  spec.description   = "Weather is a current weather API that reports conditions for any city name or zip code: real-time temperature and wind speed with compass direction, in both metric and imperial units. Paid plans add a 7-day forecast with daily highs, lows, rain chance and conditions for the week ahead."
  spec.homepage      = "https://apiverve.com/marketplace/weatherforecast?utm_source=ruby&utm_medium=referral&utm_content=homepage"
  spec.license       = "MIT"
  spec.required_ruby_version = ">= 2.7.0"

  spec.metadata["homepage_uri"] = spec.homepage
  spec.metadata["source_code_uri"] = "https://github.com/apiverve/weatherforecast-API/tree/main/ruby"
  spec.metadata["changelog_uri"] = "https://apiverve.com/changelog"
  spec.metadata["documentation_uri"] = "https://docs.apiverve.com/ref/weatherforecast"

  spec.files = Dir.glob("{lib}/**/*") + %w[README.md LICENSE]
  spec.require_paths = ["lib"]

  spec.add_dependency "faraday", ">= 1.0", "< 3.0"
  spec.add_dependency "faraday-multipart", "~> 1.0"
  spec.add_dependency "json", "~> 2.0"
end
