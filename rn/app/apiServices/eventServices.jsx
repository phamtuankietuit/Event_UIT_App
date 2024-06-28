import * as request from "../utils/request"

export const getHotEvents = async () => {
  try {
    const res = await request.getMethod(
      "events?PageSize=4&PageNumber=1&IsPublished=true",
      true
    )
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}

export const getEvents = async (pageNumber, isGetFollowing) => {
  try {
    const res = await request.getMethod(
      `events?IsPublished=true&SortBy=EndDate&SortAscending=false&pageSize=12&pageNumber=${pageNumber}&isGetFollowing=${isGetFollowing}`,
      true
    )
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}

export const getEventsSearch = async (params) => {
  try {
    const res = await request.getMethod(`events?`, true, params)
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}

export const getDetailEvent = async (id) => {
  try {
    const res = await request.getMethod("events/" + id, true)
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}

export const registerEvent = async (id, obj) => {
  try {
    const res = await request.postMethod(`events/${id}/register`, true, obj)
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}
