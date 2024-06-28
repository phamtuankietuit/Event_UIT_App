import React, { useEffect, useState, useCallback } from "react"
import {
  FlatList,
  Text,
  TouchableOpacity,
  View,
  RefreshControl,
} from "react-native"
import SearchBar from "../components/SearchBar"
import * as PageServices from "../apiServices/pageServices"
import * as EventServices from "../apiServices/eventServices"
import Page_Item from "../components/Page_Item"
import EventItem from "../components/EventItem"
import * as asyncStorage from "../store/asyncStorage"
import { useFocusEffect } from "@react-navigation/native"
const Search = () => {
  const [value, setValue] = useState("")
  const [listPage, setListPage] = useState([])
  const [listEvent, setListEvent] = useState([])
  const [refreshing, setRefreshing] = useState(false)
  const [stage, setStage] = useState(true)
  const [role, setRole] = useState("")
  const [day, setDay] = useState(new Date())
  const onRefresh = useCallback(() => {
    fetchApi()
  }, [])
  const search = () => {
    const fetchApi = async () => {
      setRefreshing(true)
      setListEvent([])
      const responseEvent = await EventServices.getEventsSearch({
        IsPublished: true,
        SearchTerm: value,
      }).catch((error) => {
        // xử lý lỗi
        if (error.response) {
          if (error.response.status === 401) {
            showToastWithGravity("Vui lòng kiểm tra lại email hoặc mật khẩu")
          } else if (error.response.status === 403) {
            showToastWithGravity("Tài khoản đã bị vô hiệu hóa")
          }
        } else {
          showToastWithGravity("Có lỗi xảy ra")
        }
      })

      if (responseEvent) {
        // Xử lý nếu response trả về
        console.log(responseEvent.events.items)
        setListEvent(responseEvent.events.items)
      }
    }
    fetchApi()
    setRefreshing(false)
  }

  useFocusEffect(
    React.useCallback(() => {
      setDay(new Date())
    }, [])
  )
  const fetchApi = async () => {
    setRefreshing(true)
    const getRole = await asyncStorage.getRole()
    setRole(getRole)
    const id = await asyncStorage.getIdAsync()
    const response = await PageServices.getPages({
      StudentId: id,
    }).catch((error) => {
      // xử lý lỗi
      if (error.response) {
        if (error.response.status === 401) {
          showToastWithGravity("Vui lòng kiểm tra lại email hoặc mật khẩu")
        } else if (error.response.status === 403) {
          showToastWithGravity("Tài khoản đã bị vô hiệu hóa")
        }
      } else {
        showToastWithGravity("Có lỗi xảy ra")
      }
    })

    if (response) {
      // Xử lý nếu response trả về
      setListPage(response.items)
    }

    const responseEvent = await EventServices.getEventsSearch({
      isPublished: true,
    }).catch((error) => {
      // xử lý lỗi
      if (error.response) {
        if (error.response.status === 401) {
          showToastWithGravity("Vui lòng kiểm tra lại email hoặc mật khẩu")
        } else if (error.response.status === 403) {
          showToastWithGravity("Tài khoản đã bị vô hiệu hóa")
        }
      } else {
        showToastWithGravity("Có lỗi xảy ra")
      }
    })

    if (responseEvent) {
      // Xử lý nếu response trả về
      // console.log(responseEvent.events.items)
      setListEvent(responseEvent.events.items)
    }
    setRefreshing(false)
  }

  useEffect(() => {
    fetchApi()
  }, [day])

  const setLikePa = async (id, value) => {
    const UserId = await asyncStorage.getIdAsync()
    const response = await PageServices.setFollow(id, {
      StudentId: UserId,
      UnitId: id,
    }).catch((error) => {
      // xử lý lỗi
      if (error.response) {
        console.log(error.response)
        if (error.response.status === 401) {
          showToastWithGravity("Vui lòng kiểm tra lại email hoặc mật khẩu")
        } else if (error.response.status === 403) {
          showToastWithGravity("Tài khoản đã bị vô hiệu hóa")
        }
      } else {
        showToastWithGravity("Có lỗi xảy ra")
      }
    })

    if (response) {
      // Xử lý nếu response trả về
      setDay(new Date())
    }
  }

  return (
    <View className='mt-2 flex-1'>
      <View className='mx-4 my-1'>
        <SearchBar
          value={value}
          handleChange={setValue}
          placeholder='Tìm kiếm bài viết hoặc trang'
          search={search}
        />
      </View>

      <View>
        <View
          className='mx-5 my-2 flex flex-row items-center rounded-3xl bg-white 
        p-1 shadow-sm shadow-black transition-all'
        >
          <TouchableOpacity
            className={
              stage === true
                ? "w-[50%] rounded-full bg-blue-600 px-2 py-2"
                : "w-[50%] rounded-full px-2 py-2"
            }
            onPress={() => setStage(true)}
          >
            <Text
              className={
                stage === true
                  ? "text-center text-sm font-semibold text-white"
                  : "text-center text-sm font-semibold"
              }
            >
              Sự kiện
            </Text>
          </TouchableOpacity>
          <TouchableOpacity
            className={
              stage === false
                ? "w-[50%] rounded-full bg-blue-600 px-2 py-2"
                : "w-[50%] rounded-full p-2 py-2"
            }
            onPress={() => setStage(false)}
          >
            <Text
              className={
                stage === false
                  ? "text-center text-sm font-semibold text-white"
                  : "text-center text-sm font-semibold"
              }
            >
              Trang
            </Text>
          </TouchableOpacity>
        </View>
        {stage === true ? (
          <FlatList
            data={listEvent}
            showsVerticalScrollIndicator={false}
            className='mx-2 bg-transparent'
            keyExtractor={(item) => item.id}
            renderItem={({ item }) => <EventItem item={item} />}
            refreshControl={
              <RefreshControl
                refreshing={refreshing}
                onRefresh={onRefresh}
                colors={["#3A57E8"]}
                tintColor='#3A57E8'
                progressViewOffset={20}
              />
            }
            ListFooterComponent={<View className='mb-52'></View>}
          />
        ) : (
          <FlatList
            data={listPage}
            showsVerticalScrollIndicator={false}
            className='mx-2 bg-transparent'
            keyExtractor={(item) => item.id}
            refreshControl={
              <RefreshControl
                refreshing={refreshing}
                onRefresh={onRefresh}
                colors={["#3A57E8"]}
                tintColor='#3A57E8'
                progressViewOffset={20}
              />
            }
            renderItem={({ item }) => (
              <Page_Item item={item} setLike={setLikePa} role={role} />
            )}
            ListFooterComponent={<View className='mb-52'></View>}
          />
        )}
      </View>
    </View>
  )
}

export default Search
