export const objectToQueryString = (params) => {
  if (!params) return ``

  const queryString = Object.keys(params)
    .map((key) => `${encodeURIComponent(key)}=${params[key].join(",")}`)
    .join("&")

  return `?${queryString}`
}
